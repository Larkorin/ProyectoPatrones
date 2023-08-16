using Assets.Scripts.Adapter;
using Assets.Scripts.Adapter.Adaptados;
using Assets.Scripts.Decorator;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.InputSystem;


public class Jugador : MonoBehaviour
{

    private Animator animator; // Variable para asignar animaciones al jugador

    private float horizontal;
    private float speed = 3f;
    private float jumpingPower = 7f;
    private bool isFacingRight = false;
    private ConsoleController consoleController;
    private IController teclado;
    private IController control;
    private InputControl activeControl { get; }
    [SerializeField] private Rigidbody2D _rb2D; // Variable para indicar las físicas del jugador
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] Slider sliderVidas;
    [SerializeField] int vidas;
    [SerializeField] private GameObject DatosEnemigo;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        _rb2D = GetComponent<Rigidbody2D>();
        sliderVidas.maxValue = vidas;
        sliderVidas.value = sliderVidas.maxValue;
        DatosEnemigo.SetActive(false);
        teclado = new KeyboardMouseController();
        consoleController = new ConsoleController();
        control = new ConsoleControllerAdaptador(consoleController);

    }


    // Update is called once per frame
    void Update()
    {        
        Gamepad gamepad = Gamepad.current;
        Keyboard keyboard = Keyboard.current;

        if (keyboard != null)
        {
            horizontal = teclado.GetHorizontalInput();
            if (teclado.IsJumpButtonDown() && IsGrounded())
            {
                _rb2D.velocity = new Vector2(_rb2D.velocity.x, jumpingPower);
            }

            if (teclado.IsJumpButtonUp() && _rb2D.velocity.y > 0f)
            {
                _rb2D.velocity = new Vector2(_rb2D.velocity.x, _rb2D.velocity.y * 0.5f);
            }
            if (horizontal != 0)
            {
                animator.SetBool("Caminando", true);
            }
            else
            {
                animator.SetBool("Caminando", false);
            }
        }

        if (gamepad != null && (gamepad.leftStick.ReadValue() != Vector2.zero || gamepad.buttonWest.isPressed || gamepad.buttonSouth.isPressed))
        {
            horizontal = control.GetHorizontalInput();
            if (control.IsJumpButtonDown() && IsGrounded())
            {
                _rb2D.velocity = new Vector2(_rb2D.velocity.x, jumpingPower);
            }

            if (control.IsJumpButtonUp() && _rb2D.velocity.y > 0f)
            {
                _rb2D.velocity = new Vector2(_rb2D.velocity.x, _rb2D.velocity.y * 0.5f);
            }
            if (horizontal != 0 || gamepad.leftStick.ReadValue() == Vector2.zero)
            {
                animator.SetBool("Caminando", true);
            }
            else
            {
                animator.SetBool("Caminando", false);
            }
        }

        Flip();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuPrincipal");
        }
    }

    private void FixedUpdate()
    {
        _rb2D.velocity = new Vector2(horizontal * speed, _rb2D.velocity.y);

    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("LimiteInferior"))
        {
            GameManager.Instance.GameOver();
            Destroy(this.gameObject);

        }

        if (collision.CompareTag("TextoBoss"))
        {
            DatosEnemigo.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag =="Rana" || collision.gameObject.tag == "Dog" || collision.gameObject.tag == "Aguila" || collision.gameObject.tag == "Extraterrestre")
        {

            vidas = vidas - 5;
            sliderVidas.value = vidas;
        }

        if (collision.gameObject.tag == "Enemigo")
        {
    
            vidas = vidas - 10;
            sliderVidas.value = vidas;
        }

        if (vidas == 0)
        {
            GameManager.Instance.GameOver();
            Destroy(this.gameObject);
        }


    }

 
}

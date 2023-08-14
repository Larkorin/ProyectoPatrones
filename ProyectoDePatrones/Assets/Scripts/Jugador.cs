using Assets.Scripts.Decorator;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Playables;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Jugador : MonoBehaviour
{

    private Animator animator; // Variable para asignar animaciones al jugador

    private float horizontal;
    private float speed = 3f;
    private float jumpingPower = 7f;
    private bool isFacingRight = false;

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

    }


    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            _rb2D.velocity = new Vector2(_rb2D.velocity.x, jumpingPower);
        }

        if (Input.GetButtonUp("Jump") && _rb2D.velocity.y > 0f)
        {
            _rb2D.velocity = new Vector2(_rb2D.velocity.x, _rb2D.velocity.y * 0.5f);
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("Caminando", true);
        }
        else if ((Input.GetKeyUp(KeyCode.D) && !Input.GetKeyUp(KeyCode.A)))
        {
            animator.SetBool("Caminando", false);
        } else if ((Input.GetKeyUp(KeyCode.D) && !Input.GetKeyUp(KeyCode.A)))
        {
            animator.SetBool("Caminando", false);
        }


        Flip();

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
            Debug.Log(vidas);
            vidas = vidas - 5;
            sliderVidas.value = vidas;
        }

        if (collision.gameObject.tag == "Enemigo")
        {
            Debug.Log(vidas);
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

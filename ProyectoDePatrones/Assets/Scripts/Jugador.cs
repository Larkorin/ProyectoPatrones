using Assets.Scripts.Decorator;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Playables;
using UnityEngine;
using UnityEngine.SceneManagement;


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

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        _rb2D = GetComponent<Rigidbody2D>();

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

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)|| Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetBool("Caminando", true);
        }
        else if ((Input.GetKeyUp(KeyCode.D) && !Input.GetKey(KeyCode.A)) || (Input.GetKeyUp(KeyCode.LeftArrow)) && !Input.GetKey(KeyCode.RightArrow))
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

    private void OnTriggerEnter2D(Collider2D limiteInferior)
    {
        GameManager.Instance.GameOver();
    }

}

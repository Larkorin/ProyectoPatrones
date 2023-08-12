using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.AbstractFactory
{
    public class JefeCueva : Enemigo
    {
        public Transform player { get; private set; }
        public SpriteRenderer spriteRenderer;
        public bool isFlipped = false;
        public float speed = 1f;
        public float attackRange = 1.1f;
        public Rigidbody2D rb;
        private Animator animator;
        private bool isAttacking = false;

        public override string Name { get { return "JefeCueva"; } }

        public override void Attack() //Función de atacar
        {
            if (isAttacking)
            {
                return;
            }
            animator = GetComponent<Animator>();
            animator.SetTrigger("Attack");
            isAttacking = true;

            //Meter funcionalidad que hace daño al jugador
        }

        public override void Process() //No se usa
        {
            //this.context = new Context(this);

            UnityEngine.Debug.Log("estoy adentro de JefeCueva ");
            throw new NotImplementedException();
        }

        public override void Run() //Funcion de correr
        {
            // Obtenemos la referencia al componente Rigidbody2D
            rb = GetComponent<Rigidbody2D>();

            // Resto del código de movimiento que tenías en BossRun
            LookAtPlayer();
            Vector2 target = new Vector2(player.position.x, rb.position.y);
            Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);
            rb.MovePosition(newPos);

            // Restablecemos la variable isAttacking para permitir otro ataque
            isAttacking = false;
        }

        void Update()
        {
            Context context = new Context(this, player, rb, attackRange);
            context.escogerEstrategia();
        }
        void Start()
        {
            // Buscar el GameObject con la etiqueta "Player" y obtener su transform.
            player = GameObject.FindGameObjectWithTag("Player").transform;

            rb = GetComponent<Rigidbody2D>();
        }

        public void LookAtPlayer()
        {
            if (player != null)
            {
                Vector3 flipped = transform.localScale;
                flipped.x = Math.Abs(flipped.x) * (transform.position.x > player.position.x ? -1f : 1f);
                transform.localScale = flipped;
            }
        }
    }
}

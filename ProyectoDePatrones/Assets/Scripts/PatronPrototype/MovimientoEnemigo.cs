using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb2D;
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private float distancia;
    [SerializeField] private LayerMask capaSuelo;
    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        rb2D.velocity = new Vector3(velocidadMovimiento * transform.right.x, rb2D.velocity.y);

        RaycastHit2D infoSuelo = Physics2D.Raycast(transform.position, transform.right, distancia, capaSuelo);

        if (infoSuelo)
        {
            Girar();

        }

    }

    private void Girar()
    {
    transform.eulerAngles= new Vector3(0,transform.eulerAngles.y +180 ,0);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + transform.right * distancia);
    }




}

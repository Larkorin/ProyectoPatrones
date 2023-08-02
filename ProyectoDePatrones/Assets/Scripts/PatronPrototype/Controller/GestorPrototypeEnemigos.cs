using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GestorPrototypeEnemigos : MonoBehaviour
{
    //int _contador = 0;
    //int _tope = 5;
    public GameObject[] _enemigos;
    //public List<EnemigoNormal> listEnemigos;
    public Canvas _Canva;
    //GameObject[] _NuevosObjetos;
    [SerializeField] private Transform[] pts;
    private float minX, maxX, minY, maxY;
    //[SerializeField] private float tiempoEnemigos;
    [SerializeField] private int cantEnemigos;
    private float tiempoSigEnemigo;
    Ranita ranita =new Ranita();


    void Start()
    {
        maxX = pts.Max(pts => pts.position.x);
        minX = pts.Min(pts => pts.position.x);
        maxY = pts.Max(pts => pts.position.y);
        minY = pts.Min(pts => pts.position.y);
        for (int i = 0; i < cantEnemigos; i++)
        {
            ClonarObjects();
        }
    }
    void Update()
    {
        //tiempoSigEnemigo += Time.deltaTime;

        //if (tiempoSigEnemigo >= tiempoEnemigos)
        //{
        //    Debug.Log("tiempoSigEnemigo: " + tiempoSigEnemigo);
        //    //tiempoSigEnemigo = 0;
        //    ClonarObjects();




        //}
    }
    private void ClonarObjects()
    {
        //ranita = new Ranita();

        //int randomEnemigos = Random.Range(0, _enemigos.Length);
        Vector3 posicionAleatoria = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY));
       
        //listEnemigos= new List<Enemigos>();
        //listEnemigos.Add(new Ranita());
        ranita.Clonar(_enemigos, posicionAleatoria, Quaternion.identity);
       
     
    }

    private GameObject Clonar()
    {
        int randomEnemigos = Random.Range(0, _enemigos.Length);

        Vector2 posicionAleatoria = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));

        // Instantiate(_enemigos[randomEnemigos], posicionAleatoria, Quaternion.identity);
        GameObject instantiatedObject = Instantiate(_enemigos[randomEnemigos], posicionAleatoria, Quaternion.identity);
        //instantiatedObject.transform.localPosition = posicion.position;//PosicionNueva();
        //instantiatedObject.transform.localScale = posicion.localScale;//new Vector3(1f, 1f, 1f);
        return instantiatedObject;
    }

    private Vector3 PosicionNueva()
    {
        return new Vector3(Random.Range(-300, 300), Random.Range(-110, 100), 0f);

    }
}

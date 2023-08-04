using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.SceneManagement;
using UnityEngine;

public class testPrototype : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemigos;
    private float minX, maxX, minY, maxY;
    [SerializeField] private Transform[] pts;
    [SerializeField] private float tiempoEnemigos;
    private float tiempoSigEnemigo;
    //public Transform pos;
    //public Transform posicionPrefabEnemigo;
    //public GameObject instancia;

    // Start is called before the first frame update
    void Start()
    {
        maxX = pts.Max(pts => pts.position.x);
        minX = pts.Min(pts => pts.position.x);
        maxY = pts.Max(pts => pts.position.y);
        minY = pts.Min(pts => pts.position.y);
       // InstanciaObject(); 
    }

    // Update is called once per frame
    void Update()
    {
        tiempoSigEnemigo += Time.deltaTime;

        if(tiempoSigEnemigo>= tiempoEnemigos)
        {
            //Hacer que aqui clone diferentes tipos de enemigos del array, (tal y como esta) pero limitando la cantidad, es decir que sean por ej: solo 3 en ese punto
            //En lugar de hacerlo aqui en el update, podria ser en el start
            //y se hace while como el del profe****            
            tiempoSigEnemigo= 0;
            clonar();
        }
    }

    private void clonar()
    {
        int randomEnemigos = Random.Range(0, _enemigos.Length);
        Vector2 posicionAleatoria = new Vector2(Random.Range(minX,maxX), Random.Range(minY,maxY));

        Instantiate(_enemigos[randomEnemigos],posicionAleatoria,Quaternion.identity);
    }

    private void InstanciaObject()
    {
        //selecciona de forma aleatoria los enemigos que se le indiquen
        int randomEnemigos = Random.Range(0, _enemigos.Length);

        //añadir una posicion
        //Vector3 posicion = _enemigos[randomEnemigos].AddComponent<Transform>().TransformVector(posicionEnemigo);



        //Genera la copia del prefab enemigo
        
       GameObject cloneEnemy= Instantiate(_enemigos[randomEnemigos]);
        //para posicionar los enemigos
        //cloneEnemy.transform.localPosition=new Vector3(8, -0, 0);
        // cloneEnemy.transform.localScale=new Vector3(6, 8, 1);


        //default
        //Instantiate(_enemigos[randomEnemigos], pos.position, _enemigos[randomEnemigos].transform.rotation);
        //Instantiate(_enemigos[randomEnemigos], posicionEnemigo, _enemigos[randomEnemigos].transform.rotation);

    }


    private Vector3 PosicionNueva(double x, double y, double z)
    {
        return new Vector3((float)x, (float)y, (float)z);
        //return new Vector3((float)9.250031, (float)3.192692, (float)-1.602994);

    }
}

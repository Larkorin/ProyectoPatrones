using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class GestorPrototypeEnemigos : MonoBehaviour
{

    public GameObject[] _enemigos;
    [SerializeField] private Transform[] pts;
    private float minX, maxX, minY, maxY;
    [SerializeField] private int cantEnemigos;
    private EnemigoNormal enemigoRana;
    private EnemigoNormal enemigoAguila;
    private EnemigoNormal enemigoDog;
    private EnemigoNormal enemigoExtraterrestre;

    public GestorPrototypeEnemigos() {
        enemigoRana = new Ranita(15,10);
        enemigoAguila = new Aguila(10,5);
        enemigoDog= new Dog(20,15);
        enemigoExtraterrestre = new Extraterrestre(20, 15);
    }
    void Start()
    {
        maxX = pts.Max(pts => pts.position.x);
        minX = pts.Min(pts => pts.position.x);
        maxY = pts.Max(pts => pts.position.y);
        minY = pts.Min(pts => pts.position.y);

        for (int i = 0; i < cantEnemigos; i++)
        {
            nuevoEnemigo();
        }
    }

    private void nuevoEnemigo()
    {
        //Debug.Log("Rana: " + enemigoRana.descripcion + " - Vida: " + enemigoRana.cantidadVida+" daño: "+enemigoRana.habilidad.cantidadDannio);
        //Debug.Log("Aguila: " + enemigoAguila.descripcion + " - Vida: " + enemigoAguila.cantidadVida + " daño: " + enemigoAguila.habilidad.cantidadDannio);

        int selectEnemigoRandom=Random.Range(0,_enemigos.Length);

        switch (selectEnemigoRandom) { 
            case 0: 
                enemigoRana.Clone(_enemigos, posicionEnemigo(), Quaternion.identity);
                break;
            case 1:
                enemigoAguila.Clone(_enemigos, posicionEnemigo(), Quaternion.identity);
                break;
            case 3:
                enemigoDog.Clone(_enemigos, posicionEnemigo(), Quaternion.identity);
                break;
            case 4:
                enemigoExtraterrestre.Clone(_enemigos, posicionEnemigo(), Quaternion.identity);
                break;
            default:
                enemigoExtraterrestre.Clone(_enemigos, posicionEnemigo(), Quaternion.identity);
                break;
        }
    }

    private Vector3 posicionEnemigo()
    {
        Vector3 posicionAleatoria = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY));

        return posicionAleatoria;

    }
}

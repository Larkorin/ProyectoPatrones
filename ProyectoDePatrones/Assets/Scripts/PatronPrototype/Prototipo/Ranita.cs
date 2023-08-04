using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Ranita : EnemigoNormal
{
    public Ranita(int cantVida, int cantDannio)
    {
        this.nombre = "Ranita";
        this.descripcion = "Soy Rana y Brinco";
        this.cantidadVida = cantVida;
        this.tagEnemigo = "Rana";
        this.habilidad = new Colision(cantDannio);
    }
    public override EnemigoNormal Clone(GameObject[] lstEnemigos, Vector2 posicion, Quaternion quaternion)
    {
        string gameObjTagEnemigos;
        for (int i = 0; i < lstEnemigos.Length; i++)
        {
            gameObjTagEnemigos = lstEnemigos[i].tag;

            if (gameObjTagEnemigos == tagEnemigo)
            {
                Instantiate(lstEnemigos[i], posicion, quaternion);
              
            }

        }

        return new Ranita(this.cantidadVida, this.habilidad.cantidadDannio);
    }


    public void Kill()
    {
        Destroy(gameObject);
    }

}

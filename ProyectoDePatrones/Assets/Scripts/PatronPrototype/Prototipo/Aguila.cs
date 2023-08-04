using System;
using UnityEngine;
using UnityEngine.UI;

public class Aguila : EnemigoNormal
{
    public Aguila(int cantVida, int cantDannio)
    {
        this.nombre = "Aguila";
        this.descripcion = "Soy un Aguila y vuelo";
        this.cantidadVida = cantVida;
        this.tagEnemigo = "Aguila";
        this.habilidad = new Colision(cantDannio);
    }
    public override EnemigoNormal Clone(GameObject[] lstEnemigos, Vector2 posicion, Quaternion quaternion)
    {
        string gameObjTagEnemigos;
        for (int i = 0; i < lstEnemigos.Length; i++)
        {
            gameObjTagEnemigos= lstEnemigos[i].tag;

            if (gameObjTagEnemigos == tagEnemigo) //si el objeto GameObject tiene un elemento que se llame Aguila entonces se clona
            {
                Instantiate(lstEnemigos[i], posicion, quaternion);
               
            }

        }

        return new Aguila(this.cantidadVida, this.habilidad.cantidadDannio);
    }

 

}

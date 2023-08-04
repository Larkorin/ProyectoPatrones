using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Extraterrestre : EnemigoNormal
{
    public Extraterrestre(int cantVida, int cantDannio)
    {
        this.nombre = "Extraterrestre";
        this.descripcion = "Soy un dinosaurio Extraterrestre";
        this.cantidadVida = cantVida;
        this.tagEnemigo = "Extraterrestre";
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

        return new Extraterrestre(this.cantidadVida, this.habilidad.cantidadDannio);
    }

  
}

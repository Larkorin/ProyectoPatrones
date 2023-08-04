using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : EnemigoNormal
{
    public Dog(int cantVida, int cantDannio)
    {
        this.nombre = "PerroAlien";
        this.descripcion = "Soy un perror alien y corro rapido";
        this.cantidadVida = cantVida;
        this.tagEnemigo = "Dog";
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

        return new Dog(this.cantidadVida, this.habilidad.cantidadDannio);
    }


}

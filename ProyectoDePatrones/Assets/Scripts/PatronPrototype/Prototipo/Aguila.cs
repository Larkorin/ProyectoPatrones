using System;
using UnityEngine;
using UnityEngine.UI;

public class Aguila 
{
    //public Aguila(Image spriteEnemigo, float posicion)
    //{
    //    this.spriteEnemigo = spriteEnemigo;
    //    this.posicion = posicion;
    //    this.CantidadVida = 30;
    //    this.tipoHabilidad=(new Volar());
    //    this.descripcion = "soy un aguila";
    //}

    //private void Awake()
    //{
    //    spriteEnemigo = transform.Find("Enemigo").GetComponent<Image>();

    //}


    ////public override Enemigos clone()
    ////{
    ////   return new Aguila(this._imgEnemigo,this.posicion);
    ////}


    //public override Enemigos Clone()
    //{
    //    GameObject clonedObject = Instantiate(gameObject, transform.parent);
    //    Aguila clonedAguila = clonedObject.GetComponent<Aguila>();



    //    return clonedAguila;
    //}
    //public Enemigos Clone(Transform pTrans)
    //{
    //    GameObject clonedObject = Instantiate(gameObject, pTrans);
    //    Aguila clonedAguila = clonedObject.GetComponent<Aguila>();

    //    return clonedAguila;
    //}
    public EnemigoNormal Clone()
    {
        throw new NotImplementedException();
    }
}

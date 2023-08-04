using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public abstract class EnemigoNormal : MonoBehaviour
{

    public Habilidad habilidad { get; set; }
    public string nombre { get; set; }
    public string descripcion { get; set; }
    public int cantEnemigo { get; set; }
    public int cantidadVida { get; set; }
    public string tagEnemigo  { get; set; }

    public EnemigoNormal() { 
    
    }

    public abstract EnemigoNormal Clone(GameObject[] lstEnemigos, Vector2 posicion, Quaternion quaternion);


}

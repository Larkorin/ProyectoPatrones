using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "Nuevo Enemigo", menuName = "ScriptableObjects/Crear Enemigo", order = 1)]
public class EnemigoNormal : ScriptableObject
{
  [SerializeField] Sprite _Sprite;
        [SerializeField] string _Nombre;
        [SerializeField] string _Descripcion;

        public Sprite Sprite => _Sprite;
        public string Nombre => _Nombre;
        public string Descripcion => _Descripcion;

        private Habilidad habilidad { get; set; }
    //public Image spriteEnemigo { get; set; }
    //public float posicion { get; set; }
    //public Habilidad tipoHabilidad { get; set; }
    //public string descripcion { get; set; }

    //public int CantidadVida { get; set; }

    //public Enemigos Clone();


}

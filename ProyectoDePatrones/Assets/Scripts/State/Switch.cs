using Assets.Scripts.AbstractFactory;
using System;
using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;

namespace Assets.Scripts.State
{
    public class Switch : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI VidaEnemigoText;
        [SerializeField] TextMeshProUGUI VidaEnemigoDescripcion;
        //public GameObject Enemigo;
        private Estado _estado;


        public Switch()
        {
            _estado = new Vivo();
        }

        public void DefinirEstado (Estado estado)
        {
            _estado = estado;
            
        }
        public void Update()
        {
            int valor = int.Parse(VidaEnemigoText.text);
            if (valor <= 0)
            {
                _estado.ControlarEstado(this);
               
                VidaEnemigoText.enabled = false;
                VidaEnemigoDescripcion.enabled = false;
            }
            DestroyObject();

        }

        public void DestroyObject()
        {
            //Debug.Log(_estado.Describir());
            
            if (_estado.Describir() == "Muerto" ) {

                
                    Destroy(GameObject.FindGameObjectWithTag("Enemigo"));

            }

        }

 
    }
}
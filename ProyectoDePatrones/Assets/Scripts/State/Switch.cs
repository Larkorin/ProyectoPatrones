using System;
using System.Collections;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.State
{
    public class Switch : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI VidaEnemigoText;
        [SerializeField] private TextMeshProUGUI VidaEnemigoDescripcion;
      
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
            int valor = Convert.ToInt32(VidaEnemigoText.text);
            if (valor <= 0)
            {
                _estado.ControlarEstado(this);
                //Debug.Log(_estado.Describir());
                VidaEnemigoText.enabled = false;
                VidaEnemigoDescripcion.enabled = false;
            }
            DestroyObject();

        }

        public void DestroyObject()
        {
            //Debug.Log(_estado.Describir());
            if (_estado.Describir() == "Muerto" ) {
                Destroy(this.gameObject);
            }
        }
    }
}
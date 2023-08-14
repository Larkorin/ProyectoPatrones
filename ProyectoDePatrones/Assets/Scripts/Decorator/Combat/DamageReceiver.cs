using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;


namespace Assets.Scripts.Decorator
{
    public class DamageReceiver : MonoBehaviour, IDamageReceiver
    {
        [SerializeField] private TextMeshProUGUI VidaEnemigoText;
        private int LifeEnemy = 500;
        [SerializeField] private GameObject gun;
        [SerializeField] private GameObject sword;
        


        public void Start()
        {
            VidaEnemigoText.SetText("500");
            
        }


        public void ReceiveDamage(int damage)
        {

           
            
            if (gun.GetComponent<Detector>().herido != false || sword.GetComponent<Detector>().herido != false)
            {
                Debug.Log(damage + "dano hecho");
                LifeEnemy = LifeEnemy - damage;
                Debug.Log("Entre al if");

            }                

            VidaEnemigoText.SetText(Convert.ToString(LifeEnemy));
             
        }


        private void ResetHerido()
        {
            gun.GetComponent<Detector>().herido = false;
            sword.GetComponent<Detector>().herido = false; 
        }


    }
}
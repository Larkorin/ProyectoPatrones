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
        [SerializeField]  private GameObject gun;
        [SerializeField] private GameObject sword;


        public void Start()
        {
            VidaEnemigoText.SetText("500");
            
        }

        public void ReceiveDamage(int damage, Color color)
        {
            
            Debug.Log("El monto a restar es " +damage +"color es "+ color);
           
           
            if (gun.GetComponent<Detector>().herido != false || sword.GetComponent<Detector>().herido != false)
            {
                LifeEnemy = LifeEnemy - damage;
              
            }                
            Debug.Log(LifeEnemy);
            VidaEnemigoText.SetText(Convert.ToString(LifeEnemy));
          
        }

        


    }
}
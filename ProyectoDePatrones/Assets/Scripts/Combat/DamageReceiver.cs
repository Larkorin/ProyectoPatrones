using System;
using System.Collections;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.Decorator
{
    public class DamageReceiver : MonoBehaviour, IDamageReceiver
    {
        [SerializeField] private TextMeshProUGUI[] _damageText;
        private int _LastTextUsed = 0;
        //Recibe dano nuestro personaje principal y se resta a la vida

  
        public void ReceiveDamage(int damage, Color color)
        {
            Debug.Log("El monto a restar es " +damage +"color es "+ color);
           
        }

    }
}
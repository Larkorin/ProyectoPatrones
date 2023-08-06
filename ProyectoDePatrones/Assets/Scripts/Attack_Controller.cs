using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Decorator;
using Assets.Scripts.Decorator.Decorado;
using JetBrains.Annotations;
using System.Runtime.CompilerServices;

public class Attack_Controller : MonoBehaviour
{
    [SerializeField] private DamageReceiver _damageReceiver;

    private SinArma _sinArma;
    private AttackerDecorator _swordAttacker;
    private AttackerDecorator _gunAttacker;
    private int contador = 0;

    public GameObject Sword_idle;
    public GameObject Gun_idle;
    public GameObject Sword_attack;
    public GameObject Gun_attack;
    public GameObject Jugador;

    private void Awake() {
        const int damage = 0;
        const int swordDamage = 20;
        const int gunDamage = 30;
        
        _sinArma = new SinArma(damage);
        _swordAttacker = new SwordAttackerDecorator(_sinArma,swordDamage);
        _gunAttacker = new GunAttackerDecorator(_sinArma,gunDamage);
    }
    private void Update()
    {
        //Codigo para sacar las ARMAS
        if (Input.GetKeyDown(KeyCode.F1))
        {
            contador++;
            if (contador > 3)
            {
                contador = 1;
            }
            switch (contador)
            {
                case 1:
                    Sword_idle.SetActive(true);
                    
                    
                    break;
                case 2:
                    Sword_idle.SetActive(false);
                    Gun_idle.SetActive(true);
                   
                    break;
                case 3:
                    Sword_idle.SetActive(false);
                    Gun_idle.SetActive(false);
                    break;
                    
            }
        }
        // Codigo para que el muñeco ataque con ENTER
        if ((Input.GetKeyDown(KeyCode.Return)))
        {
            if (contador == 1)
            {
                Sword_idle.SetActive(false);
                Jugador.GetComponent<SpriteRenderer>().enabled = false;
                Sword_attack.SetActive(true);
                _swordAttacker.Attack(_damageReceiver);



            } else if (contador == 2) {
                Gun_idle.SetActive(false);
                Jugador.GetComponent<SpriteRenderer>().enabled = false;
                Gun_attack.SetActive(true);
                _gunAttacker.Attack(_damageReceiver);
                
                
            }
        }
        if ((Input.GetKeyUp(KeyCode.Return)))
        {
            if (contador == 1)
            {
                Sword_idle.SetActive(true);
                Jugador.GetComponent<SpriteRenderer>().enabled = true;
                Sword_attack.SetActive(false);
                

            } else if (contador == 2){
                Gun_idle.SetActive(true);
                Jugador.GetComponent<SpriteRenderer>().enabled = true;
                Gun_attack.SetActive(false);
               

            }
        }

    }
}

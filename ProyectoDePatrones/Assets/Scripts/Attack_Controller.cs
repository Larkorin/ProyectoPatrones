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

    public GameObject Sword;
    public GameObject Gun;

    private void Awake() {
        const int damage = 100;
        const int swordDamage = 20;
        const int gunDamage = 30;
        
        _sinArma = new SinArma(damage);
        _swordAttacker = new SwordAttackerDecorator(_sinArma,swordDamage);
        _gunAttacker = new GunAttackerDecorator(_sinArma,gunDamage);
    }
    private void Update()
    {
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
                    Sword.SetActive(true);
                    _swordAttacker.Attack(_damageReceiver);
                    break;
                case 2:
                    Sword.SetActive(false);
                    Gun.SetActive(true);
                    _gunAttacker.Attack(_damageReceiver);
                    break;
                case 3:
                    Sword.SetActive(false);
                    Gun.SetActive(false);
                    break;
                    
            }
        }
    }
}

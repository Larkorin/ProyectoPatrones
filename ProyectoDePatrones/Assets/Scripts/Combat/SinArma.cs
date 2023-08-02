using UnityEditor;
using UnityEngine;
using Assets.Scripts.Decorator;

namespace Assets.Scripts.Decorator
{
    public class SinArma : IAttacker
    {
        private readonly int _damage;
        public SinArma(int damage) { _damage = damage; }

        public void Attack(IDamageReceiver damageReceiver)
        {
            damageReceiver.ReceiveDamage(_damage, Color.white);
        }
    }
}
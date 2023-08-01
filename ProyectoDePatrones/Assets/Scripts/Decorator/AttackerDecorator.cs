using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.Decorator.Decorado
{
    public class AttackerDecorator : IAttacker
    {
       private readonly IAttacker _attacker;

        public AttackerDecorator(IAttacker attacker)
        {
            _attacker = attacker;

        }

        public virtual void Attack(IDamageReceiver damageReceiver)
        {
            _attacker.Attack(damageReceiver);
        }
    }
}
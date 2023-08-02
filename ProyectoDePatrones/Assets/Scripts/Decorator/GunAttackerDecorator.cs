using UnityEngine;

namespace Assets.Scripts.Decorator.Decorado
{
    public class GunAttackerDecorator : AttackerDecorator
    {
        private readonly int _gunDamage;

        public GunAttackerDecorator(IAttacker attacker, int gunDamage) : base(attacker)
        {
            _gunDamage = gunDamage;
        }

        public override void Attack(IDamageReceiver damageReceiver)
        {
            base.Attack(damageReceiver);
            damageReceiver.ReceiveDamage(_gunDamage, Color.green);
        }
    }
}
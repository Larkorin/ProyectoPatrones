using UnityEngine;


namespace Assets.Scripts.Decorator.Decorado
{
    public class SwordAttackerDecorator : AttackerDecorator
    {
        private readonly int _swordDamage;

        public SwordAttackerDecorator(IAttacker attacker, int swordDamage) : base(attacker)
        {
            _swordDamage = swordDamage;
        }

        public override void Attack(IDamageReceiver damageReceiver)
        {
            base.Attack(damageReceiver);
            damageReceiver.ReceiveDamage(_swordDamage);
        }
    }
}
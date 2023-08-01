namespace Assets.Scripts.Decorator
{
    public interface IAttacker
    {
        void Attack(IDamageReceiver damageReceiver);
    }
}
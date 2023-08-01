using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Decorator
{
    public interface IDamageReceiver
    {
        void ReceiveDamage(int damage, Color color);
    }
}
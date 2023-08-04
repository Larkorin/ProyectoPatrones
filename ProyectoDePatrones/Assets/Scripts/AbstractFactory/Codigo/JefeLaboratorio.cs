using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.AbstractFactory
{
    public class JefeLaboratorio : Enemigo
    {
        public override string Name { get { return "JefeLaboratorio"; } }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void Process()
        {
            UnityEngine.Debug.Log("estoy adentro de JefeLaboratorio ");
            throw new NotImplementedException();
        }

        public override void Run()
        {
            throw new NotImplementedException();
        }
    }
}

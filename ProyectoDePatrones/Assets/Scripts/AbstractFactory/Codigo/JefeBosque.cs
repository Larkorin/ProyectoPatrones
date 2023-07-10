using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.AbstractFactory
{
    public class JefeBosque : Enemigo
    {
        public override string Name { get { return "JefeBosque"; } }

        public override void Process()
        {
            UnityEngine.Debug.Log("estoy adentro de JefeBosque ");
            throw new NotImplementedException();
        }
    }
}

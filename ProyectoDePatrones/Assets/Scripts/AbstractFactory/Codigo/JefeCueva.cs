using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.AbstractFactory
{
    public class JefeCueva : Enemigo
    {
        public override string Name { get { return "JefeCueva"; } }

        public override void Process()
        {
            UnityEngine.Debug.Log("estoy adentro de JefeCueva ");
            throw new NotImplementedException();
        }
    }
}

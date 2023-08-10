using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.State
{
    public class Vivo : Estado
    {
        public override void ControlarEstado(Switch sw)
        {
            sw.DefinirEstado(new Muerto());
        }

        public override string Describir()
        {
            return "Vivo";
        }

    }
}
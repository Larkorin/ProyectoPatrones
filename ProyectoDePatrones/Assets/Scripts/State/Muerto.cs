using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.State
{
    public class Muerto : Estado
    {
        public override void ControlarEstado(Switch sw)
        {
            sw.DefinirEstado(new Vivo());
        }
        public override string Describir()
        {
            return "Muerto";
        }

    }
}
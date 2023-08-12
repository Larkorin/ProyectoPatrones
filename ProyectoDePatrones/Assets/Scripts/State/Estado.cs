using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.State
{
    public abstract class Estado 
    {
        public abstract void ControlarEstado(Switch sw);

        public abstract string Describir();
    }
}
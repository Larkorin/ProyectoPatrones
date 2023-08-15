using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Adapter
{
    public class KeyboardMouseController : IController
    {
        public float GetHorizontalInput()
        {
            return Input.GetAxisRaw("Horizontal"); //Revisa el movimiento horizontal
        }

        public bool IsJumpButtonDown()
        {
            return Input.GetButtonDown("Jump"); //Revisa si se esta presionando el boton de saltar
        }

        public bool IsJumpButtonUp()
        {
            return Input.GetButtonUp("Jump"); //Revisa si se para de presional el boton se saltar
        }
    }
}

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
            return Input.GetAxisRaw("Horizontal");
        }

        public bool IsJumpButtonDown()
        {
            return Input.GetButtonDown("Jump");
        }

        public bool IsJumpButtonUp()
        {
            return Input.GetButtonUp("Jump");
        }
    }
}

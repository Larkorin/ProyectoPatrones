using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Adapter.Adaptados
{
    public class ConsoleController
    {
        public ConsoleController() { }

        public float JoystickHorizontal()
        {
            return Input.GetAxisRaw("Horizontal");
        }

        public bool PresionarSaltar()
        {
            if(Input.GetKeyDown(KeyCode.Joystick1Button0))
            {
                Debug.Log("Preisono boton x");
            }
            return Input.GetKeyDown(KeyCode.Joystick1Button0);
            //return Input.GetButtonDown("Jump");
        }

        public bool SoltarSaltar()
        {
            return Input.GetKeyUp(KeyCode.Joystick1Button0);
            //return Input.GetButtonUp("Jump");
        }
    }
}

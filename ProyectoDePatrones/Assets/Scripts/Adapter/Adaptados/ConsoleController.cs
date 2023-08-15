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
            return Input.GetAxisRaw("Horizontal"); //Revisa el movimiento horizotal
        }

        public bool PresionarSaltar()
        {
            if(Input.GetKeyDown(KeyCode.Joystick1Button0)) //Revisa si se esta presionando el boton cuadrado en un control de playstation o la X en un control de xbox
            {
                Debug.Log("Preisono boton x");
            }
            return Input.GetKeyDown(KeyCode.Joystick1Button0); //Revisa si se esta presionando el boton cuadrado en un control de playstation o la X en un control de xbox
        }

        public bool SoltarSaltar()
        {
            return Input.GetKeyUp(KeyCode.Joystick1Button0); //Revisa si se solto el boton cuadrado en un control de playstation o la X en un control de xbox
        }
    }
}

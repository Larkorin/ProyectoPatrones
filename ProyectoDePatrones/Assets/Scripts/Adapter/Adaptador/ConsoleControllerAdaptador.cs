﻿using Assets.Scripts.Adapter.Adaptados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Adapter
{
    public class ConsoleControllerAdaptador : IController
    {
        private ConsoleController consoleController;

        public ConsoleControllerAdaptador()
        {
            this.consoleController = new ConsoleController();
        }

        public ConsoleControllerAdaptador(ConsoleController newConsoleController)
        {
            this.consoleController = newConsoleController;
        }

        public float GetHorizontalInput()
        {

            return this.consoleController.JoystickHorizontal();
        }

        public bool IsJumpButtonDown()
        {
            return this.consoleController.PresionarSaltar();
        }

        public bool IsJumpButtonUp()
        {
            return this.consoleController.SoltarSaltar();
        }
    }
}

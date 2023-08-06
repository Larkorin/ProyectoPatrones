using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour, ISceneLoader
{
    private LogicaCambioEscena logicaCambioEscena;
    private int indiceNivel;

    // Método para configurar el proxy con el componente original.
    public void Configurar(LogicaCambioEscena logicaCambioEscena)
    {
        this.logicaCambioEscena = logicaCambioEscena;
    }

    // Implementación de la operación CambiarNivel() utilizando el componente original.
    public void CambiarNivel(int indice)
    {
        if (logicaCambioEscena != null)
        {
            logicaCambioEscena.CambiarNivel(indice);
        }
    }

     public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            CambiarNivel(indiceNivel);
        }
    }
}

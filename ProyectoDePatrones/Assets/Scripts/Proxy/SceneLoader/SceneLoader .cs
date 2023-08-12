using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour, ISceneLoader
{
    [SerializeField] private LogicaCambioEscena logicaCambioEscena;
    [SerializeField] public int indiceNivel;
    [SerializeField] private GameObject banderas;

    // Método para configurar el proxy con el componente original.
    //public void Configurar(LogicaCambioEscena logicaCambioEscena)
    //{
    //    this.logicaCambioEscena = logicaCambioEscena;
    //}

    // Implementación de la operación CambiarNivel3() utilizando el componente original.
    public void CambiarNivel(int indice)
    {
        if (indice != null)
        {
            logicaCambioEscena.CambiarNivel(indice);
        }
    }

    public void Update()

    {

        if (banderas.GetComponent<Detector>().bandera==true)


        {
            Debug.Log("llego");

            Debug.Log(indiceNivel);
             CambiarNivel(indiceNivel);

        }

    }
}
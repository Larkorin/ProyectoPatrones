using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Playables;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bandera : MonoBehaviour
{
	public Bandera()
	{
	}


    private void OnTriggerEnter2D(Collider2D Jugador)
    {
        GameManager.Instance.GameOver();
    }
}

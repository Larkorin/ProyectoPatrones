using Assets.Scripts.AbstractFactory;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumer : MonoBehaviour
{
    private EnemigoFactory currentEnemigoFactory;

    public void Configure(EnemigoFactory enemigoFactory)
    {
        currentEnemigoFactory = enemigoFactory;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F1))
        {
            currentEnemigoFactory.Create("JefeLaboratorio");
        }

        if (Input.GetKeyUp(KeyCode.F2))
        {
            currentEnemigoFactory.Create("JefeBosque");
        }

        if (Input.GetKeyUp(KeyCode.F3))
        {
            currentEnemigoFactory.Create("JefeCueva");
        }

    }
}

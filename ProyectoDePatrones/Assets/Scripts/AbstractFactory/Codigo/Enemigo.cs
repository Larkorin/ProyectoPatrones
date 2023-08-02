using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemigo : MonoBehaviour
{
    public abstract string Name { get; }
    public abstract void Process();
}

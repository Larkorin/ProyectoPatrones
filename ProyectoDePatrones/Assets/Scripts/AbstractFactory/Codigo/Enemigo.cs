using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemigo : MonoBehaviour
{
    public Context context;
    public abstract string Name { get; }
    public abstract void Process();

    public abstract void Run();

    public abstract void Attack();
}

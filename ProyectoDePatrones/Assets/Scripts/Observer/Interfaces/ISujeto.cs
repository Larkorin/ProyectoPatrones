using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISujeto
{
    void addObserver(IObservador var1);

    void removeObserver(IObservador var1);

    void notifyObservers();
}

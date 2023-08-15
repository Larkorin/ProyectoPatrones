using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISujeto
{
    void addObserver(IObservador observador);

    void removeObserver(IObservador observador);

    void notifyObservers();
}

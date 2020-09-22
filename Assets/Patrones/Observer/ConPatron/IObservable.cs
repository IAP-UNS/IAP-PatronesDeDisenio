using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObservable
{
    void Register(IObserver o);
    void Unresgister(IObserver o);
    void Notify();
}

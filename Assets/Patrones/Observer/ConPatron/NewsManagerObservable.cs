using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewsManagerObservable : MonoBehaviour, IObservable
{
    private string currentPost = "";
    public Text currentPostLabel;
    public InputField inputField;

    private List<IObserver> suscribers;

    void Start()
    {
        suscribers = new List<IObserver>();
    }

    public void UpdatePost()
    {
        currentPost = inputField.text;
        currentPostLabel.text = currentPost;
        Notify();
    }

    public string GetCurrentPost()
    {
        return currentPost;
    }

    public void Notify()
    {
        foreach(IObserver o in suscribers)
        {
            o.OnNotify();
        }
    }

    public void Register(IObserver o)
    {
        suscribers.Add(o);
    }

    public void Unresgister(IObserver o)
    {
        suscribers.Remove(o);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserSuscriberObserver : MonoBehaviour,IObserver
{
    public NewsManagerObservable newsManager;
    public Text currentPostLabel;
    private string currentPost = "";

    void Start()
    {
        newsManager.Register(this);
    }

    public void OnNotify()
    {
        string newPost = newsManager.GetCurrentPost();
        currentPost = newPost;
        currentPostLabel.text = currentPost; 
    }
}

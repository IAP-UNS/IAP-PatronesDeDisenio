using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserSubscriber : MonoBehaviour
{
    public NewsManager newsManager;
    public Text currentPostLabel;
    private string currentPost = "";

    void Update()
    {
        string newPost = newsManager.GetCurrentPost();
        if (!newPost.Equals(currentPost))
        {
            currentPost = newPost;
            currentPostLabel.text = currentPost;
        }
    }
}

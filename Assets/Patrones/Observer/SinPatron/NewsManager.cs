using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewsManager : MonoBehaviour
{
    private string currentPost = "";
    public Text currentPostLabel;
    public InputField inputField;

    public void UpdatePost()
    {
        currentPost = inputField.text;
        currentPostLabel.text = currentPost;
    }

    public string GetCurrentPost()
    {
        return currentPost;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageProvider : MonoBehaviour
{
    public static ImageProvider instance;

    private void Awake()
    {
        ImageProvider.instance = GetComponent<ImageProvider>();
    }

    public Sprite HomeIcon,HeartRateIcon,RunningIcon,ConfigurationIcon;

}

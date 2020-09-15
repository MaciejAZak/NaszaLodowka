using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenResolution : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Screen resolution is: " + Screen.currentResolution);
        Debug.Log("Current width is: " + Screen.width);
        Debug.Log("Current height is: " + Screen.height);
        Debug.Log("Currently available resolutions are: " + Screen.resolutions);
        Debug.Log("Currently fullscreen? " + Screen.fullScreen);
    }
}

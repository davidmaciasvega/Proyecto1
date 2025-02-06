using UnityEngine;
using UnityEngine.UI;

public class OpenURL : MonoBehaviour
{
    public string url; // Public variable to set the URL in the Inspector

    void Start()
    {
        // Get the Button component and add a listener to the onClick event
        GetComponent<Button>().onClick.AddListener(OpenLink);
    }

    void OpenLink()
    {
        // Open the URL in the default web browser
        Application.OpenURL(url);
    }
}
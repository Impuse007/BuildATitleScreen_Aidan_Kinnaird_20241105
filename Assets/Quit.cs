using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    // You can attach the button from the Unity editor in the Inspector
    public Button quitButton;

    void Start()
    {
        // Make sure the button is assigned
        if (quitButton != null)
        {
            quitButton.onClick.AddListener(QuitApplication);
        }
        else
        {
            Debug.LogWarning("Quit button not assigned!");
        }
    }

    // Function that quits the application
    void QuitApplication()
    {
        // If running in the editor, stop the play mode
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        // If running as a build, quit the application
        Application.Quit();
#endif

        Debug.Log("Application Quit!");
    }
}
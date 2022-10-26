using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    int buttonCount = 0;
    int switchCount = 0;

    [SerializeField] Text buttonText;
    [SerializeField] Text switchText;

    [SerializeField] GameObject endMenu;

    /// <summary>
    /// Updates the text displayed above the switch and the button
    /// </summary>
    void Update()
    {
        buttonText.text = buttonCount.ToString();
        switchText.text = switchCount.ToString();
    }

    /// <summary>
    /// Checks the count and displays the end menu when the combined count equals 10
    /// </summary>
    public void EndSceneMenuCheck()
    {
        endMenu.SetActive((buttonCount + switchCount) == 10);
    }

    /// <summary>
    /// Resets the count of the scene
    /// </summary>
    public void CountReset()
    {
        buttonCount = 0;
        switchCount = 0;
    }

    /// <summary>
    /// Tallies the count of each button press and checks for the end scene conditions
    /// </summary>
    public void CountButtonPress()
    {
        buttonCount++;
        EndSceneMenuCheck();
    }

    /// <summary>
    /// Tallies the count of each switch flip and checks for the end scene conditions
    /// </summary>
    public void CountSwitchPress()
    {
        switchCount++;
        EndSceneMenuCheck();
    }

    /// <summary>
    /// Closes the application, applied to the NO button in the end menu
    /// </summary>
    public void EndApp()
    {
        Application.Quit();
    }
}

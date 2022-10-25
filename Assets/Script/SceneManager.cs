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

    void Update()
    {
        buttonText.text = buttonCount.ToString();
        switchText.text = switchCount.ToString();
    }

    public void EndSceneMenuCheck()
    {
        if((buttonCount + switchCount) == 10)
        {
            endMenu.SetActive(true);
        }
    }

    public void CountReset()
    {
        buttonCount = 0;
        switchCount = 0;
    }

    public void CountButtonPress()
    {
        buttonCount++;
        EndSceneMenuCheck();
    }

    public void CountSwitchPress()
    {
        switchCount++;
        EndSceneMenuCheck();
    }

    public void EndApp()
    {
        Application.Quit();
    }
}

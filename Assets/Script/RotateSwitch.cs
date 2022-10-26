using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateSwitch : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] SceneManager sceneManager;
    [SerializeField] RotateCoin rotateCoin;

    [SerializeField] GameObject upSwitch;
    [SerializeField] GameObject downSwitch;

    Vector3 initialMousePostion = Vector3.positiveInfinity;

    /// <summary>
    /// Handle pointer down event
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerDown(PointerEventData eventData)
    {
        //Record mouse position when player clicks on the switch
        initialMousePostion = Input.mousePosition;

        //Debug.Log("OnPointerDown");
    }

    /// <summary>
    /// Handle pointer up event
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerUp(PointerEventData eventData)
    {
        //Check if the mouse is in a "higher" position than when the user clicked on the switch
        if (initialMousePostion.y < Input.mousePosition.y)
        {
            initialMousePostion = Vector3.positiveInfinity;
            sceneManager.CountSwitchPress();
            rotateCoin.CoinSwitch();
            StartCoroutine(SwitchFlip());
        }

        //Debug.Log("OnPointerUp");
    }

    /// <summary>
    /// Handle switch flip on two second timer
    /// </summary>
    /// <returns></returns>
    IEnumerator SwitchFlip()
    {
        //Switch up
        downSwitch.SetActive(false);
        upSwitch.SetActive(true);

        //Wait for 2 seconds
        yield return new WaitForSecondsRealtime(2);

        //Switch down
        downSwitch.SetActive(true);
        upSwitch.SetActive(false);
    }
}

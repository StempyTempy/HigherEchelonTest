using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateSwitch : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] SceneManager sceneManager;

    [SerializeField] GameObject upSwitch;
    [SerializeField] GameObject downSwitch;

    Vector3 initialMousePostion = Vector3.zero;
    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("OnPointerDown");
        initialMousePostion = Input.mousePosition;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //Debug.Log("OnPointerUp");
        if (initialMousePostion.y < Input.mousePosition.y)
        {
            sceneManager.CountSwitchPress();
            StartCoroutine(SwitchFlip());
        }
    }

    IEnumerator SwitchFlip()
    {
        downSwitch.SetActive(false);
        upSwitch.SetActive(true);

        yield return new WaitForSecondsRealtime(2);

        downSwitch.SetActive(true);
        upSwitch.SetActive(false);
    }
}

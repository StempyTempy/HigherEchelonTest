using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateCoin : MonoBehaviour
{
    [SerializeField] RectTransform rectTransform;
    [SerializeField] float rotation = 0f;
    [SerializeField] float rotationDirection = -1f;
    [SerializeField] float rotationSpeed = 120f;

    // Update is called once per frame
    void Update()
    {
        rectTransform.Rotate(new Vector3(0f, 0f, rotation * rotationDirection * rotationSpeed * Time.deltaTime));
    }

    public void RotateButton()
    {
        if (rotation == 1f)
            rotation = 0f;
        else
            rotation = 1f;
    }

    public void CoinSwitch()
    {
        rotationDirection *= -1f;
    }

    public void CoinReset()
    {
        rotation = 0f;
        rotationDirection = -1f;
        rectTransform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }
}

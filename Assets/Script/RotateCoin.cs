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

    void Update()
    {
        //Rotates the coin based on the state of several variables
        rectTransform.Rotate(new Vector3(0f, 0f, rotation * rotationDirection * rotationSpeed * Time.deltaTime));
    }

    /// <summary>
    /// Toggles rotation on and off
    /// </summary>
    public void RotateButton()
    {
        rotation = rotation == 1f ? 0f : 1f;
        //Debug.Log(rotation);
    }

    /// <summary>
    /// Toggles the direction of the coin rotation
    /// </summary>
    public void CoinSwitch()
    {
        rotationDirection *= -1f;
        //Debug.Log(rotationDirection);
    }

    /// <summary>
    /// Reset the coin rotation, position, and direction
    /// </summary>
    public void CoinReset()
    {
        rotation = 0f;
        rotationDirection = -1f;
        rectTransform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }
}

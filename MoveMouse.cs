using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMouse : MonoBehaviour
{
    public GameObject trigger;
    public GameObject Mouse;
    public GameObject movingMouse;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Mouse.SetActive(false);
        movingMouse.SetActive(true);
        trigger.SetActive(false);
    }
}

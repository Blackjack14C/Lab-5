using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public GameObject objective3;
    public GameObject objective3Completed;
    public KeyCode interact;
    public GameObject doorClosed;
    public GameObject doorOpened;
    public GameObject open;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        open.SetActive(true);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        open.SetActive(false);
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Input.GetKey(interact))
        {
            doorClosed.SetActive(false);
            doorOpened.SetActive(true);
            objective3.SetActive(false);
            objective3Completed.SetActive(true);
        }
    }
}

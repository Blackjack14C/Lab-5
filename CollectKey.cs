using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKey : MonoBehaviour
{
    public GameObject objective1;
    public GameObject objective1Completed;
    public GameObject objective2;
    public KeyCode interact;
    private bool KeyCollected = false;
    public GameObject Key;
    public GameObject chest;
    public GameObject interactbutton;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        interactbutton.SetActive(true);

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        interactbutton.SetActive(false);
    }
    // Update is called once per frame
    void OnCollisionStay2D()
    {
        if (Input.GetKey(interact))
        {
            KeyCollected = true;
            Key.SetActive(false);
            chest.SetActive(true);
            objective1.SetActive(false);
            objective1Completed.SetActive(true);
            objective2.SetActive(true);
        }
        
    }
}

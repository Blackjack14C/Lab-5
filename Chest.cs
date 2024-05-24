using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objective2;
    public GameObject objective2Completed;
    public GameObject objective3;
    public GameObject chestClossed;
    public GameObject ChestOppened;
    public GameObject Door;
    public KeyCode open;
    public GameObject interact;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        interact.SetActive(true);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        interact.SetActive(false);
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Input.GetKey(open))
        {
            chestClossed.SetActive(false);
            ChestOppened.SetActive(true);
            Door.SetActive(true);
            objective2.SetActive(false);
            objective2Completed.SetActive(true);
            objective3.SetActive(true);
        }
    }
}

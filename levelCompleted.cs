using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class levelCompleted : MonoBehaviour
{
    public GameObject levelcomplete;
    public GameObject objectives;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        objectives.SetActive(false);
        levelcomplete.SetActive(true);
    }
}

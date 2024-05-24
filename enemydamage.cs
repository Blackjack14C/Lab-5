using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydamage : MonoBehaviour
{
    public GameObject objectives;
    public GameObject levelcomplete;
    public GameObject badButton;
    public GameObject goodbutton;
    [SerializeField] float sanity, maxSanity = 10f;
    // Start is called before the first frame update
    void Start()
    {
        sanity = maxSanity;
    }

    // Update is called once per frame
    public void TakeDamage(float damageAmount)
    {
        sanity = sanity - damageAmount;
        
        if(sanity <= 0)
        {
            Destroy(gameObject);
            objectives.SetActive(false);
            levelcomplete.SetActive(true);
            badButton.SetActive(false);
            goodbutton.SetActive(true);
        }
    }
}

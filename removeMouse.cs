using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeMouse : MonoBehaviour
{
    public GameObject movingMouse;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movingMouse.transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        movingMouse.SetActive(false);
    }
}

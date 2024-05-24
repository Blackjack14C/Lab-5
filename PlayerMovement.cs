using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rigidbody;
    [SerializeField] private float speed;
    private float timer;
    public GameObject ProjectilePrefab;
    public GameObject LaunchOffset;
    public KeyCode shoot;
    public KeyCode left;
    public KeyCode right;
    public bool facingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (facingRight == true && Input.GetKey(left))
        {
            transform.Rotate(0,180,0);
            facingRight = false;
        }
        if (facingRight == false && Input.GetKey(right))
        {
            transform.Rotate(0, 180, 0);
            facingRight = true;
        }
        if (timer > 25)
        {
            timer = 0;
        }
        //lookAtMouse
        //LookAtMouse();

        //Move

        Move();
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(shoot) & timer < 1)
        {

            Instantiate(ProjectilePrefab, LaunchOffset.transform.position, transform.rotation);

        }
        if (Input.GetKey(shoot))
        {
            timer = timer + 1;


        }

    }

    private void LookAtMouse()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.right = mousePos - new Vector2(transform.position.x, transform.position.y);
    }

    private void Move()
    {
        var input = new Vector2(x: Input.GetAxisRaw("Horizontal"), y: Input.GetAxisRaw("Vertical"));
        rigidbody.velocity = input.normalized * speed;
    }
}

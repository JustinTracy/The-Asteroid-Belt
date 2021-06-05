using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    float horizontal; 
    float vertical;
    public float speed = 3f; 
    public KeyCode pressUp;
    public KeyCode pressDown;
    public KeyCode pressLeft;
    public KeyCode pressRight;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

   void Update()
   {
        Move();
        Rotate();
   }

   void Move() 
   {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector2 position = rigidbody2d.position;
        position.x = position.x + 50 * horizontal * Time.deltaTime;
        position.y = position.y + 50 * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);
   }

   void Rotate()
   {
        if (Input.GetKeyDown(pressUp))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);
        }
        if (Input.GetKeyDown(pressDown))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 180);
        }
        if (Input.GetKeyDown(pressLeft))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 90);
        }
        if (Input.GetKeyDown(pressRight))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, -90);
        }
   }
}

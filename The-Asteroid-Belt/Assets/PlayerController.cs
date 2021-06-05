using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3f; 
    public KeyCode pressUp;
    public KeyCode pressDown;
    public KeyCode pressLeft;
    public KeyCode pressRight;

   void Update()
   {
        Move();
        Rotate();
   }

   void Move() 
   {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        transform.position = position;
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

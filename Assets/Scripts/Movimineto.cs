using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimineto : MonoBehaviour
{
    public float speed;
    //private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.up * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.up * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * Time.deltaTime * speed;
        }

        //    float horizontalMove = Input.GetAxisRaw("Horizontal");
        //    rb.AddForce(new Vector2(horizontalMove * speed, 0), ForceMode2D.Force);

        //    float verticalMove = Input.GetAxisRaw("Vertical");
        //    rb.AddForce(new Vector2(0, verticalMove * speed), ForceMode2D.Force);
    }
}

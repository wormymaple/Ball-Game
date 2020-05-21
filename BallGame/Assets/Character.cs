using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float XSpeed;
    public float YSpeed;
    public bool CanJump;
    static public int TotalUT;
    static public bool CanMove = true;
    // Start is called before the first frame update
    void Start()
    {
        CanMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (CanMove == true)
        {
            if (Input.GetKey(KeyCode.A))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-XSpeed, GetComponent<Rigidbody2D>().velocity.y);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(XSpeed, GetComponent<Rigidbody2D>().velocity.y);
            }
            if (Input.GetKey(KeyCode.Tab))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);
            }
            if (Input.GetKeyDown(KeyCode.Space) && CanJump == true)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, YSpeed);
                CanJump = false;
            }
        }
    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        CanJump = true;
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        CanJump = false;
    }
}

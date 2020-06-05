using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D rigidBody;
    public bool isgrounded = false;

    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        jump();
        if (Input.GetKey(KeyCode.Space))//can thrust while rotating
        {
            rigidBody.AddRelativeForce(Vector2.up);
        }
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal")*Time.deltaTime, 0f, 0f);

    }

    void jump()
    {
        if (Input.GetButtonDown("Jump") && isgrounded == true){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }
    }


}

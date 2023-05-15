using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementScript : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] int jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, jumpForce));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector2(-5f, rb.velocity.y);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(5f, rb.velocity.y);
        }
    }
}

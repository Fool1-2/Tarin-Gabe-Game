using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementScript : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] int jumpForce;
    Transform transform;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
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
            //rb.velocity = new Vector2(-5f, rb.velocity.y);
            transform.position = transform.position + new Vector3(-speed, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            //rb.velocity = new Vector2(5f, rb.velocity.y);
            transform.position = transform.position + new Vector3(speed, 0, 0);
        }
    }
}

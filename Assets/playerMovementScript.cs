using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementScript : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] int jumpForce;
    Transform transform;
    [SerializeField] float speed;
    bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.AddForce(new Vector2(0, jumpForce));
            canJump = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            //rb.velocity = new Vector2(-5f, rb.velocity.y);
            transform.position = transform.position + new Vector3(-speed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            //rb.velocity = new Vector2(5f, rb.velocity.y);
            transform.position = transform.position + new Vector3(speed, 0, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            Debug.Log("touchedFloor");
            canJump = true; 
        }
    }
}

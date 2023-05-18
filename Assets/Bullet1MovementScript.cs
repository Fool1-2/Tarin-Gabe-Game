using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1MovementScript : MonoBehaviour
{
    Transform tf;
    Rigidbody2D rb;
    [SerializeField] int speed;
    float xSpeed;
    float ySpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tf = GetComponent<Transform>();
        tf.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
    }

    // Update is called once per frame
    void Update()
    {

   
    }
    private void FixedUpdate()
    {
        xSpeed = Mathf.Sin(Mathf.Deg2Rad * tf.rotation.z) * speed;
        Debug.Log("xSpeed: " + xSpeed);
        ySpeed = Mathf.Cos(Mathf.Deg2Rad * tf.rotation.z) * speed;
        Debug.Log("ySpeed: " + ySpeed);
        //rb.velocity = new Vector2(xSpeed, ySpeed);
        transform.position = transform.position + (new Vector3(xSpeed, ySpeed) * Time.deltaTime);
    }
}

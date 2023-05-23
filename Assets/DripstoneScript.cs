using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DripstoneScript : MonoBehaviour
{
    public int difLevel;
    Rigidbody2D rb;
    gameManagerScript gm;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.5f * difLevel;
        gm = GameObject.Find("GMObject").GetComponent<gameManagerScript>();
        SetGravSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gm.gameOver = true;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Border")
        {
            Destroy(this.gameObject);
        }
    }

    void SetGravSpeed()
    {
        int i = Random.Range(0, Mathf.RoundToInt(gm.gameTimer / 5));
        if (i < 6)
        {
            rb.gravityScale = 0.5f;
        }
        else if (i < 10)
        {
            rb.gravityScale = 1;
        }
        else
        {
            rb.gravityScale = 2;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            Destroy(this.gameObject);
        }
    }

}

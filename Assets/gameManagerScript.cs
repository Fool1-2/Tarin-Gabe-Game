using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManagerScript : MonoBehaviour
{
    public float spawnTimer;
    public GameObject dripstone;
    public float spawnSpeed = 5;
    public bool gameOver;

    public float gameTimer;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(checkSpawnSpeed());
    }

    // Update is called once per frame
    void Update()
    {
        gameTimer += Time.deltaTime;
        spawnTimer += Time.deltaTime;
        if (spawnTimer > spawnSpeed)
        {
            //Creates a new dripstone at a random x position with a height of seven 
            Instantiate(dripstone, new Vector3(Random.Range(-4.8f, 4.8f), 7, 0), Quaternion.identity);
            spawnTimer = 0;
        }
        
    }
    IEnumerator checkSpawnSpeed()
    {
        if (spawnSpeed > 1)
        {
            spawnSpeed = 5 - 0.05f;
        }
        Debug.Log("changed");
        yield return new WaitForSeconds(1f);
        StartCoroutine(checkSpawnSpeed());
    }


}

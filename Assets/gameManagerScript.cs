using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManagerScript : MonoBehaviour
{
    public float spawnTimer;
    public GameObject bullet1;
    public List<Vector3> spawnPositions;
    public int spawnSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer > spawnSpeed)
        {
            spawnTimer = 0;
            Instantiate(bullet1, spawnPositions[Random.Range(0, 3)], Quaternion.identity);
        }
    }
}

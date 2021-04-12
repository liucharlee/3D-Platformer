using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn2 : MonoBehaviour
{
    public Rigidbody myEnemyPrefab; // public = in Inspector, Rigidbody3D = for our convenience
    
    public float spawnTimer = 0.5f;
    public float spawnTimerReset = 0.5f; //reset timer value

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = spawnTimer/Time.deltaTime;
        spawnTimerReset = spawnTimerReset/Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer--;

        if(spawnTimer <= 0){
            //spawn enemy above player position
            Instantiate( myEnemyPrefab, transform.position + new Vector3( Random.Range(-20f, 20f), Random.Range(10f, 20f), Random.Range(-20f, 20f) ), Quaternion.identity );
            spawnTimer = spawnTimerReset;
        }
        
    }
}

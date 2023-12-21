using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject prefabToSpawn;
    private GameObject player;
    private GameObject[] spawnPositions;

    public GameObject ground;

    public float spawnCoolTime = 3.0f;
    private float currentTime = 0.0f;
    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        spawnPositions = GameObject.FindGameObjectsWithTag("Respawn");
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if( currentTime >= spawnCoolTime)
        {
            currentTime = 0;

            int Index = Random.Range(0, spawnPositions.Length);
            GameObject ball = Instantiate(prefabToSpawn, spawnPositions[Index].transform);
            ball.GetComponent<MoveToPlayer>().target = player;
            ball.transform.SetParent(ground.transform);
        }
    }
}

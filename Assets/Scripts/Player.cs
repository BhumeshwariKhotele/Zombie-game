using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Player : MonoBehaviour
{
    //public Transform player;
    public Transform playerSpawnPoints;
    Transform[] spawnPoints;
    public bool reSpawn;
    bool lastToggle;
    FirstPersonController temp;
    // Start is called before the first frame update
    void Start()
    {

        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();

        temp = GetComponent<FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {

        if (lastToggle != reSpawn)
        {
            ReSpawn();
            temp.enabled = false;
        }
        else
        {
            temp.enabled = true;
            lastToggle = reSpawn;
        }
    }
    public void ReSpawn()
    {
        int i = Random.Range(1, spawnPoints.Length);

        transform.position = spawnPoints[i].transform.position;
        reSpawn = false;

    }

}


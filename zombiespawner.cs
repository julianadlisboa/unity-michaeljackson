using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiespawner : MonoBehaviour
{
     public Transform[] spawnpoints;

    public GameObject zombie;

    private void Start(){
        InvokeRepeating("SpawnZombie", 3, 4);
    }

     void SpawnZombie(){
        int r = Random.Range(0, spawnpoints.Length);
        GameObject Zombie = Instantiate(zombie, spawnpoints[r].position, Quaternion.identity);
     }

}

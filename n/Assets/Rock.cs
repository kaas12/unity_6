using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public GameObject Faller;
    public GameObject Explosion;
    public float spawnWait = 2;

    public void CreateRock() 
    {
        float PosX = Random.Range(-2.7f, 2.7f);
        Vector3 Position = new Vector3(PosX, 6, 0);
        Instantiate(Faller, Position, Quaternion.Euler(0f, 0f, 0f));
    }

    void Start() 
    {
        InvokeRepeating("CreateRock", 2f, 2f);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Instantiate(Explosion, transform.position, Quaternion.Euler(0f, 0f, 0f));
        playerstats.score ++;
        Destroy(gameObject);
    }
}

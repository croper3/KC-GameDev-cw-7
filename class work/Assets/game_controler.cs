using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_controler : MonoBehaviour
{
    public Transform spawn;
    public Transform spawnleft;
    public Transform spawnright;

    public GameObject enemy;
    public float delay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnenemy", 0f, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnenemy()
    {
        Instantiate(enemy, spawn);
        int randNum = Random.Range(1, 4);
        if(randNum == 1)
        {
            Instantiate(enemy, spawnleft);
        }
        else if (randNum == 2)
        {
            Instantiate(enemy, spawn);
        }
        else
        {
            Instantiate(enemy, spawnright);
        }

        

        
    }
}

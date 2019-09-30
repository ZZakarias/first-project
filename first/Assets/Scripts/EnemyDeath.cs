using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Health>().deathEvent.AddListener(remm);
    }

    private void remm()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

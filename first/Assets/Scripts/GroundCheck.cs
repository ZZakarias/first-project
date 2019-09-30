using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{

    public bool Grounded = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// det er et script der tjekker om "playeren" er på jorden eller i luften
    /// </summary>
    /// <param name="col">col er colliderens navn </param>
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Ground"))
        {
            Grounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Ground"))
        {
            Grounded = false;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        
        OnTriggerEnter2D(col);
    }
    

}

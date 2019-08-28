using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField]
    private float Forcemod = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Hvis space bliver trykket ned så hopper den
      if(Input.GetKeyDown(KeyCode.Space))
        {
            //den for kraft til at hoppe og at den hopper impulse og ikke accelere
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * Forcemod, ForceMode2D.Impulse);
        }
    }
}

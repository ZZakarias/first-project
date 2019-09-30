using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField]
    private float Forcemod = 10f;

    private GroundCheck gc;

    // Start is called before the first frame update
    void Start()
    {
        gc = GetComponentInChildren<GroundCheck>();
    }

    // Update is called once per frame
    void Update()
    {
        //Hvis space bliver trykket ned så hopper den og så tjekker den om den er på joden
      if(Input.GetKeyDown(KeyCode.Space) && gc. Grounded)
        {
            //den for kraft til at hoppe og at den hopper impulse og ikke accelere
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * Forcemod, ForceMode2D.Impulse);
        }
    }
}

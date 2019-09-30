using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraMovement : MonoBehaviour
{
    // transform positionnen af en ting, private er en privat ting, vector3 er de 3 cordinater(x,y,z)
    private Transform player;

    private Vector3 offset;

    private Vector3 speed = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    { //den finder game object med tagget player?
        player = GameObject.FindGameObjectWithTag("Player").transform;
        // den gemmer den orginale afstand til playeren
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // den er gør at kameraet følger med playern men er lidt langsommere til det
        transform.position = Vector3.SmoothDamp(transform.position, offset + player.position, ref speed, 0.5f);
    }
}

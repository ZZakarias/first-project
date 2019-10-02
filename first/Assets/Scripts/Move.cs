using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    [SerializeField]
    [Range(0.5f, 10f)]
    private float forceMod;

    Rigidbody2D rb2d;
    // Start is called before the first frame update

    Animator Animator;

    SpriteRenderer SR;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
        SR = GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void Update()
    {
        float horizontalForce = Input.GetAxis("Horizontal");
        if (Mathf.Abs(rb2d.velocity.x) > 5)
        {
            Debug.Log("du kører for hurtigt");
            rb2d.velocity *= 0.95f;
        }

        if (horizontalForce!=0)
        {
            rb2d.AddForce(horizontalForce * Vector2.right * forceMod, ForceMode2D.Impulse);
        }

        Animator.SetFloat("speed", Mathf.Abs(rb2d.velocity.x));

        if (rb2d.velocity.x != 0)
        {
            SR.flipX = (rb2d.velocity.x < 0f);
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    //den bullet vi instanciere
    [SerializeField]
    GameObject bullet;
    // player til så er den spiller og omvendt er det til en fjende
    [SerializeField]
    bool playerMode = false;
    // rate of fire
    [SerializeField]
    float cooldown = 1f;

    private Vector3 direction;
    // knappen man trykker på for at skyde
    [SerializeField]
    private KeyCode shootKey = KeyCode.Mouse0;
    //gør at man ikke kan skyde på cooldown
    bool _currentlycoolingdown = false;


    // Start is called before the first frame update
    void Start()
    {
        if(!playerMode)
        {
            StartCoroutine(EnemyShootTimer(cooldown));
               
        }
    }

    private IEnumerator EnemyShootTimer(float cooldown)
    {
        while (true)
        {
            yield return new WaitForSeconds(cooldown);

            CreateBulletTowardsTarget(GameObject.FindGameObjectWithTag("Player").transform.position);

        }
    }

    private GameObject CreateBulletTowardsTarget(Vector3 position)
    {
        return Instantiate(bullet, transform.position + (position - transform.position).normalized, Quaternion.identity, null);
    }

    // Update is called once per frame
    void Update()
    {
        //Denne er efterladt tom, 
        if(playerMode && Input.GetKeyDown(shootKey) && !_currentlycoolingdown)
        {
            Debug.Log("vi skyder!");
            GameObject temp = CreateBulletTowardsTarget(GetMousePos());
            temp.GetComponent<Rigidbody2D>().AddForce((GetMousePos() - transform.position).normalized * 20f, ForceMode2D.Impulse);
        }

    }

    private static Vector3 GetMousePos(bool normalized = false)
    {
        Vector3 camvec = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        camvec.z = 0f;
        return normalized ? camvec.normalized : camvec;
    }

}

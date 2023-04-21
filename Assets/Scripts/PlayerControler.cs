using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    public float speed = 8f;
    private Rigidbody2D body;
    public GameObject playerBulletGO; // this is our player's bullet prefab
    public GameObject bulletPosition01;
    public GameObject bulletPosition02;


    void Awake()
    {

        body = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject bullet01 = (GameObject) Instantiate(playerBulletGO);
            bullet01.transform.position = bulletPosition01.transform.position; // set the bullet initial position

            GameObject bullet02 = (GameObject) Instantiate(playerBulletGO);
            bullet02.transform.position = bulletPosition02.transform.position; // set the bullet initial position            
        }

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        
    }

    private void FixedUpdate()
    {
        // body.velocity = new Vector2(vertical*speed,body.velocity.y);
        // body.velocity = new Vector2(horizontal*speed,body.velocity.x);




            body.velocity = speed * new Vector2(horizontal, vertical).normalized;


        
    }
    //Prefab - shoot
    private void LateUpdate() {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,-8,8),Mathf.Clamp(transform.position.y,-4,4),transform.position.z);    
       Debug.Log(transform.position); 
    }


}

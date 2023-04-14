using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    public float speed = 8f;
    private Rigidbody2D body;


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
    }


}

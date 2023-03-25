using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBG : MonoBehaviour
{
    private BoxCollider2D boxcollider;
    private Rigidbody2D rb;
    private float higth;
    private float speed = -3f;
    // Start is called before the first frame update
    void Start()
    {
        boxcollider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        higth= boxcollider.size.y;
        rb.velocity = new Vector2(0,speed);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<-higth)
        {
          Reposition();
        }
    }

    private void Reposition()
    {
        Vector2 vector = new Vector2(0,higth*2f);
        transform.position = (Vector2) transform.position + vector;
    }
}

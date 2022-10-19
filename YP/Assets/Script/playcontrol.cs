using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playcontrol : MonoBehaviour
{
    private Rigidbody2D rb;
    private float HorizontalMove = 0f;
    public float speed = 1f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal")* speed;
    }

    private void FixedUpdate()
    {
        
    }
}

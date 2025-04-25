using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour
{
    Rigidbody2D rigidbody2;
    float moveForce = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal"); // Gets A/D or Left/Right arrow input
        rigidbody2.AddForce(new Vector2(moveInput * moveForce, 0f));
    }
}

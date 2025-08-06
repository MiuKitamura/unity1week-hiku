using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganman_Ganman : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Down(float force) {
        rb.AddForce(new Vector2(force, 10.0f));
    }
}

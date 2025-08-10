using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ganman_Ganman : MonoBehaviour
{
    public GameObject bullet;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bullet.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Down(float force) {
        rb.AddForce(new Vector2(force, 10.0f));
    }

    public void Shot(float force) {
        bullet.SetActive(true);
        bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(force, 0.0f));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piano_ColorChange : MonoBehaviour
{
    private SpriteRenderer sr;
    
    public bool isHit = false;


    [SerializeField] private Color changeColor;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("onpu")&&isHit == false)  
        {
            sr.color = changeColor;

            isHit = true;

            collision.gameObject.SetActive(false);


        }
    }
}

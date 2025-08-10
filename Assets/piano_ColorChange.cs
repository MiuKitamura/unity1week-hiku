using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piano_ColorChange : MonoBehaviour
{
    private SpriteRenderer sr;
    
    public bool isHit = false;

    private new GameObject  gameObject;

    [SerializeField] private Color changeColor;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        gameObject = sr.gameObject;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("onpu")&&isHit == false)  
        {
            if(gameObject.name == "empty_onpu_1" || gameObject.name == "empty_onpu_2")
            {
               
                FindFirstObjectByType<piano_SE_piano1>().PlaySE();

            }
            else if(gameObject.name == "empty_onpu_3" || gameObject.name == "empty_onpu_4" || gameObject.name == "empty_onpu_7")
            {
                FindFirstObjectByType<piano_SE_piano2>().PlaySE();
            }
            else if(gameObject.name == "empty_onpu_5" || gameObject.name == "empty_onpu_6")
            {
                FindFirstObjectByType<piano_SE_piano3>().PlaySE();
            }







            sr.color = changeColor;

            isHit = true;

            collision.gameObject.SetActive(false);


        }
    }
}

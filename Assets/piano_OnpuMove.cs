using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piano_OnpuMove : MonoBehaviour
{
    public float amplitude = 2f; // è„â∫à⁄ìÆÇÃïù
    public float speed = 2f;     // ë¨Ç≥
    private Vector3 startPos;
    private bool isMove = true;

    public piano_MouseClick MouseClick;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if(MouseClick.isDragging ==true)
        {
            isMove = false;
        }

        if(isMove ==true)
        {
            // è„â∫Ç…ìÆÇ≠
            transform.position = startPos + new Vector3(0, Mathf.Sin(Time.time * speed) * amplitude, 0);
        }
       
        
    }
}

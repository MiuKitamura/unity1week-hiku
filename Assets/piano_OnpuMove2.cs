using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piano_OnpuMove2 : MonoBehaviour
{
    public float amplitude = 2f; // ���E�ړ��̕�
    public float speed = 2f;     // ����
    private Vector3 startPos;
    private bool isMove = true;

    public piano_MouseClick MouseClick;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (MouseClick.isDragging == true)
        {
            isMove = false;
        }

        if (isMove == true)
        {
            // ���E�ɓ���
            transform.position = startPos + new Vector3(Mathf.Sin(Time.time * speed), 0 * amplitude, 0);
        }


    }
}

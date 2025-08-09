using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class piano_MouseClick : MonoBehaviour
{
    public Camera mainCamera;
    private Rigidbody2D rb;
    public bool isDragging = false;
    private Vector2 offset;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (mainCamera == null) mainCamera = Camera.main;
    }

    void Update()
    {
        Vector2 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        // �h���b�O�J�n����
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D hit = Physics2D.OverlapPoint(mousePos);
            if (hit != null && hit.gameObject == gameObject)
            {
                isDragging = true;
                offset = (Vector2)transform.position - mousePos;
            }
        }

        //��������
        if (Input.GetMouseButtonUp(0) && isDragging)
        {
            isDragging = false;


           
        }



        // �h���b�O���̓}�E�X�Ǐ]
        if (isDragging)
        {
            Vector2 newPos = mousePos + offset;
            rb.MovePosition(newPos);
        }
    }

 
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (isDragging && collision.CompareTag(targetTag))
    //    {

    //        if (collision.TryGetComponent<piano_ColorChange>(out var target))
    //        {

    //            Debug.Log("��������");

    //            if (target.isHit == true)
    //            {


    //                // �F���ς���ĂȂ���Ώ����Ȃǂ̏���

    //                Debug.Log("��������");
    //                // �I�u�W�F�N�g�������ăh���b�O����
    //                Destroy(gameObject);
    //                isDragging = false;
    //            }


    //        }



                
    //    }
    //}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minus_MouseClickDrop : MonoBehaviour
{
    private Camera mainCamera;//�ϊ�����Ƃ��悤
    private Rigidbody2D rb;

    public bool isChangeToMinus = false;//�}�C�i�X�ɂȂ�����

    void Start()
    {
        mainCamera = Camera.main;  // ���C���J�������擾
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))  // ���N���b�N�����u��
        {
            Vector2 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);

            // �}�E�X�ʒu�ɂ���R���C�_�[��T��
            Collider2D hit = Physics2D.OverlapPoint(mousePos);

            if (hit != null&&hit.gameObject == this.gameObject)
            {
                //���ɗ�������
                rb.gravityScale = 1.0f;

                //���ʉ�
                FindFirstObjectByType<minus_SE_ToP>().PlaySE();

                isChangeToMinus =true;



            }
        }




    }

    //�J�����O�ɏo����
    void OnBecameInvisible()
    {

        Destroy(rb);
    }



}

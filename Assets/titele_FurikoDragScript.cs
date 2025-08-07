using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class titele_FurikoDragScript : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Rigidbody2D endPointRigidbody;

    private bool isDragging = false;//�͂�ł��邩
    private Vector2 dragOffset;

    public bool isPull=false;//������������
    public float pullBorder_Y;//�������蔻��̋��E���C���l
    public int pullCnt = 0;//������������


    void Update()
    {
        // �}�E�X���N���b�N
        if (Input.GetMouseButtonDown(0))
        {
            //�}�E�X�̉�ʍ��W�����[���h���W�ɕϊ�
            Vector2 mouseWorldPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);

            //�}�E�X�̈ʒu�ɓ����蔻�肪���邩
            Collider2D hit = Physics2D.OverlapPoint(mouseWorldPos);

            //�͂񂾃I�u�W�F�N�g���I�_�Ȃ�
            if (hit != null && hit.attachedRigidbody == endPointRigidbody)
            {
                isDragging = true;
                dragOffset = endPointRigidbody.position - mouseWorldPos;

                // �h���b�O���͕�����~
                endPointRigidbody.isKinematic = true;
            }
        }

        // �}�E�X�������Ƃ�
        if (Input.GetMouseButtonUp(0) && isDragging)
        {
            isDragging = false;

            // ���������ĊJ
            endPointRigidbody.isKinematic = false;
        }

        // �h���b�O���͏I�_���}�E�X�ɂ��Ă���
        if (isDragging)
        {
            Vector2 mouseWorldPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            Vector2 targetPos = mouseWorldPos + dragOffset;

            endPointRigidbody.MovePosition(targetPos);
        }


        //�{�[�_�[�܂ň�����������
        if(endPointRigidbody.position.y <pullBorder_Y)
        {

            isPull = true;
            pullCnt++;

        }



    }
}

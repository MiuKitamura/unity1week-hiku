using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minus_MouseChangeColor : MonoBehaviour
{
    private Camera mainCamera;
    private SpriteRenderer spriteRenderer;

    private Color originalColor;//���Ƃ̐F�ۑ�


    [SerializeField] private Color changeColor = Color.yellow;//�ύX����F

    void Start()
    {
        mainCamera = Camera.main;
        spriteRenderer = GetComponent<SpriteRenderer>(); //�I�u�W�F�N�g��SpriteRenderer�Q�b�g
        originalColor = spriteRenderer.color;
    }

    void Update()
    {
        //�X�N���[�����W���Q�[�����̃��[���h���W�ɕϊ��@�@�}�E�X�̈ʒu��
        Vector2 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        //�R���C�_�[�T��
        Collider2D hit = Physics2D.OverlapPoint(mousePos);

        if (hit != null && hit.gameObject == this.gameObject)
        {
            //���̃X�N���v�g�̃Q�[���I�u�W�F�N�g�Ȃ�

            spriteRenderer.color = changeColor;  // ���F�ɕς���
        }
        else
        {
            spriteRenderer.color = originalColor; // ���̐F�ɖ߂�
        }
    }
}

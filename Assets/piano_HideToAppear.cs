using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piano_HideToAppear : MonoBehaviour
{
    public float fadeSpeed = 1f; // 1�b�Ŋ��S�ɕ\��

    private SpriteRenderer sr;
    private Color color;

    public piano_ChangePict ChangePict;

    public piano_ColorChange[] ColorChange;//�C���X�y�N�^�[�ŃZ�b�g����@�������̕���
    public piano_ToonColorChange ToonColorChanges;//�g���L��


    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        color = sr.color;
        color.a = 0f; // �ŏ��͊��S�ɓ���
        sr.color = color;
    }

    void Update()
    {

        if (ColorChange[0].isHit == true &&
            ColorChange[1].isHit == true &&
            ColorChange[2].isHit == true &&
            ColorChange[3].isHit == true &&
            ColorChange[4].isHit == true &&
            ColorChange[5].isHit == true &&
            ColorChange[6].isHit == true &&
            ToonColorChanges.isHit == true)
        { 
            
            // alpha�l�����X�ɑ��₷
            color.a += fadeSpeed * Time.deltaTime;
            sr.color = color;

            // ���S�ɕ\�����ꂽ��I��
            if (color.a >= 1f)
            {
                color.a = 1f;
                sr.color = color;
                enabled = false; // ���̃X�N���v�g���~�߂�
            }
        }

       
    }

}

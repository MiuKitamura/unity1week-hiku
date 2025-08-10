using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minus_ChangeNumber : MonoBehaviour
{
    public Text[] texts;  // �C���X�y�N�^�[��3�Z�b�g

    public int currentIndex = 0;

    public int correctCnt = 0;//�����̐���

    public bool isCorrect = false;//����������


    void Start()
    {
        ShowText(currentIndex);
    }

    void ShowText(int index)
    {
        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].gameObject.SetActive(i == index);
        }
    }

    void OnMouseDown()
    {
        // ���̃I�u�W�F�N�g���N���b�N���ꂽ�Ƃ��ɌĂ΂��
        currentIndex = (currentIndex + 1) % texts.Length;
        ShowText(currentIndex);

        //���ʉ�
        FindFirstObjectByType<minus_SE_Crick>().PlaySE_Crick();


        if (currentIndex ==correctCnt)
        {
            isCorrect = true;

        }
        else
        {
            isCorrect = false;
        }


    }
}

using NUnit.Framework.Constraints;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titele_PullToHideObjectScript : MonoBehaviour
{

    public titele_FurikoDragScript titele_FurikoDragScript;  // �Q�Ƃ��C���X�y�N�^�[�Őݒ�

    public GameObject objectToHide;//��\���ɂ���I�u�W�F�N�g

    private bool isHide = false;//��񂾂��Ăԏ���


    // Update is called once per frame
    void Update()
    {
        if(titele_FurikoDragScript.isPull == true&&isHide == false)
        {

            //��\���ɂ���
            objectToHide.SetActive(false);

            isHide = true;


        }
    }
}

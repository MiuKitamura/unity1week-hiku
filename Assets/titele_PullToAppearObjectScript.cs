using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titele_PullToAppearObjectScript : MonoBehaviour
{

    public titele_FurikoDragScript titele_FurikoDragScript;  // �Q�Ƃ��C���X�y�N�^�[�Őݒ�

    public GameObject objectToAppear;//�\���ɂ���I�u�W�F�N�g

    private bool isAppear = false;//��񂾂��Ăԗp

    void Start()
    {
        objectToAppear.GetComponent<UnityEngine.UI.Text>().enabled = false;  // ��\��
    }
    

    // Update is called once per frame
    void Update()
    {


        if (titele_FurikoDragScript.isPull == true&& isAppear == false)
        {

            Debug.Log("�\��������");

            objectToAppear.GetComponent<UnityEngine.UI.Text>().enabled = true;  // ��\��

            isAppear = true;


        }



    }
}

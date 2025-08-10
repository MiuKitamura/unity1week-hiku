using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titele_PullToAppearObjectScript : MonoBehaviour
{

    public titele_FurikoDragScript titele_FurikoDragScript;  // �Q�Ƃ��C���X�y�N�^�[�Őݒ�

    public GameObject objectToAppear;//�\���ɂ���I�u�W�F�N�g

    public bool isAppear = false;//��񂾂��Ăԗp

    public titele_BgmController bgmController;

    public bool isBgmPlayer = false;  // �C���X�y�N�^�[�ň�����`�F�b�N


    void Start()
    {
        objectToAppear.GetComponent<UnityEngine.UI.Text>().enabled = false;  // ��\��

        

        if (isBgmPlayer == true)
        {
            bgmController = FindObjectOfType<titele_BgmController>();
        }

    }
    

    // Update is called once per frame
    void Update()
    {


        if (titele_FurikoDragScript.isPull == true&& isAppear == false)
        {

            Debug.Log("�\��������");

            objectToAppear.GetComponent<UnityEngine.UI.Text>().enabled = true;  // �\��

            isAppear = true;
            if(!(bgmController ==null)&&isBgmPlayer ==true)
            {
                Debug.Log("�ȂȂ���");


                bgmController.PlayBGM();


            }
            

        }
        



    }
}

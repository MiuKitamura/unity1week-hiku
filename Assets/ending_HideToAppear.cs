using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ending_HideToAppear : MonoBehaviour
{
    public Text newText; // �����ɕς�����Text�R���|�[�l���g������

    public ending_FurikoDrag FurikoDrag;


    void Start()
    {
       newText.enabled = false;//��\��
    }

    void Update()
    {
        if(!(newText == null))
        {
            if (FurikoDrag.pullCnt >= 1)
            {
                Debug.Log("�\��������");
                newText.enabled = true;


            }
            else
            {
                Debug.Log("�\�����Ȃ���");
                newText.enabled = false;
            }

        }
       

    }
}

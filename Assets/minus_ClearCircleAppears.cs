using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minus_ClearCircleAppears : MonoBehaviour
{

    public minus_ChangeNumber[] changeNumberObjects;//�C���X�y�N�^�[�ŃZ�b�g����@�������̕���
    public minus_MouseClickDrop mouseClickDrop;//�v���X����}�C�i�X�ɕς�����

    public GameObject minus_objectToAppear;//�\���ɂ���I�u�W�F�N�g

    private bool isAppear = false;//��񂾂��Ăԗp


    // Start is called before the first frame update
    void Start()
    {
        minus_objectToAppear.GetComponent<SpriteRenderer>().enabled = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (changeNumberObjects[0].isCorrect ==true &&
            changeNumberObjects[1].isCorrect == true &&
            changeNumberObjects[2].isCorrect == true &&
            mouseClickDrop.isChangeToMinus == true &&
            isAppear ==false)
        {

            Debug.Log("�\��������");
            minus_objectToAppear.GetComponent<SpriteRenderer>().enabled = true;

            isAppear = true;

        }
        
    }
}

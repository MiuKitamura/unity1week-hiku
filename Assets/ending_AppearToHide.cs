using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class ending_AppearToHide : MonoBehaviour
{
    public Text newText; //��\��Text
    public GameObject objectToHide;//��\���ɂ���I�u�W�F�N�g

    public Camera mainCamera;//���C���J����

    public ending_MoveCamera MoveCamera;


    void Start()
    {

    }

    void Update()
    {

        if (mainCamera.orthographicSize >= MoveCamera.targetSize)
        {
            if (objectToHide == null)
            {
                Destroy(newText);
            }
            else
            {
                Destroy(objectToHide);
            }



        }


    }
}

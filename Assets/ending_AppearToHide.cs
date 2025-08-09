using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class ending_AppearToHide : MonoBehaviour
{
    public Text newText; //非表示Text
    public GameObject objectToHide;//非表示にするオブジェクト

    public Camera mainCamera;//メインカメラ

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

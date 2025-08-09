using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending_MoveCamera : MonoBehaviour
{

    public Camera mainCamera;
    public float zoomSpeed = 2f;
    public float targetSize = 10f;

    public ending_FurikoDrag FurikoDrag;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FurikoDrag.pullCnt >=6)
        {
            if (mainCamera.orthographicSize< targetSize)
            {
                //徐々にzoomアウト
                mainCamera.orthographicSize += zoomSpeed * Time.deltaTime;

                if (mainCamera.orthographicSize > targetSize)
                {
                    mainCamera.orthographicSize = targetSize;
                }
            }


        }



    }
}

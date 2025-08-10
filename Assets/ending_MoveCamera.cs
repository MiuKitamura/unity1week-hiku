using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending_MoveCamera : MonoBehaviour
{

    public Camera mainCamera;
    public float zoomSpeed = 2f;
    public float targetSize = 10f;

    public ending_FurikoDrag FurikoDrag;
    public titele_BgmController BgmController;
    public bool isBgmOne = false;

    public FadeInOut fade;
    public bool isOne = false;

    // Start is called before the first frame update
    void Start()
    {
        if (BgmController == null)
        {
            BgmController = FindObjectOfType<titele_BgmController>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(FurikoDrag.pullCnt >=6)
        {
            if (mainCamera.orthographicSize< targetSize)
            {
               if(isBgmOne ==false)
                {
                    BgmController.FadeOutAndStop(6);
                    isBgmOne=true;
                }


                //徐々にzoomアウト
                mainCamera.orthographicSize += zoomSpeed * Time.deltaTime;

                if (mainCamera.orthographicSize > targetSize)
                {
                    mainCamera.orthographicSize = targetSize;

                    if (isOne == false)
                    {
                        isOne = true;
                        StartCoroutine(fade.GameEnd());
                      
                    }


                }





            }


        }


       


    }

    //IEnumerator ExecuteAfterDelay()
    //{

    //    yield return new WaitForSeconds(1.5f); // 3秒待つ
    //    StartCoroutine(fade.GameEnd());


    //}


}

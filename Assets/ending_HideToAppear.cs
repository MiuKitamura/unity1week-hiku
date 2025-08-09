using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ending_HideToAppear : MonoBehaviour
{
    public Text newText; // ここに変えたいTextコンポーネントを入れる

    public ending_FurikoDrag FurikoDrag;


    void Start()
    {
       newText.enabled = false;//非表示
    }

    void Update()
    {
        if(!(newText == null))
        {
            if (FurikoDrag.pullCnt >= 1)
            {
                Debug.Log("表示したよ");
                newText.enabled = true;


            }
            else
            {
                Debug.Log("表示しないよ");
                newText.enabled = false;
            }

        }
       

    }
}

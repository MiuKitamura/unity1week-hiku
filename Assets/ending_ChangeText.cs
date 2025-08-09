using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ending_ChangeText : MonoBehaviour
{
    public Text newText; // ここに変えたいTextコンポーネントを入れる

    public ending_FurikoDrag FurikoDrag;

    public bool isChange = false;

    public int fontSize = 20;

    public Vector3 position = Vector3.zero;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FurikoDrag.pullCnt ==1)
        {
            newText.text = "Thank you for playing";

            newText.fontSize = fontSize;

            newText.rectTransform.position = position;

            isChange = true;

        }


    }
}

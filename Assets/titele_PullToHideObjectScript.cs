using NUnit.Framework.Constraints;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titele_PullToHideObjectScript : MonoBehaviour
{

    public titele_FurikoDragScript titele_FurikoDragScript;  // 参照をインスペクターで設定

    public GameObject objectToHide;//非表示にするオブジェクト

    private bool isHide = false;//一回だけ呼ぶ処理


    // Update is called once per frame
    void Update()
    {
        if(titele_FurikoDragScript.isPull == true&&isHide == false)
        {

            //非表示にする
            objectToHide.SetActive(false);

            isHide = true;


        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titele_PullToAppearObjectScript : MonoBehaviour
{

    public titele_FurikoDragScript titele_FurikoDragScript;  // 参照をインスペクターで設定

    public GameObject objectToAppear;//表示にするオブジェクト

    public bool isAppear = false;//一回だけ呼ぶ用

    public titele_BgmController bgmController;

    public bool isBgmPlayer = false;  // インスペクターで一つだけチェック


    void Start()
    {
        objectToAppear.GetComponent<UnityEngine.UI.Text>().enabled = false;  // 非表示

        

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

            Debug.Log("表示したよ");

            objectToAppear.GetComponent<UnityEngine.UI.Text>().enabled = true;  // 表示

            isAppear = true;
            if(!(bgmController ==null)&&isBgmPlayer ==true)
            {
                Debug.Log("曲ながす");


                bgmController.PlayBGM();


            }
            

        }
        



    }
}

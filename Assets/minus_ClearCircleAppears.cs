using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minus_ClearCircleAppears : MonoBehaviour
{

    public minus_ChangeNumber[] changeNumberObjects;//インスペクターでセットする　＜数字の方＞
    public minus_MouseClickDrop mouseClickDrop;//プラスからマイナスに変えた方

    public GameObject minus_objectToAppear;//表示にするオブジェクト

    private bool isAppear = false;//一回だけ呼ぶ用

    public FadeInOut fade;
   


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

            Debug.Log("表示したよ");
            minus_objectToAppear.GetComponent<SpriteRenderer>().enabled = true;

            isAppear = true;

            FindFirstObjectByType<minus_SE_Correct>().PlaySE();
            StartCoroutine(ExecuteAfterDelay());



        }
        
    }

    IEnumerator ExecuteAfterDelay()
    {
        if(isAppear ==true)
        {
            yield return new WaitForSeconds(1.5f); // 1.5秒待つ
            StartCoroutine(fade.GameEnd());
        }
        
    }


}

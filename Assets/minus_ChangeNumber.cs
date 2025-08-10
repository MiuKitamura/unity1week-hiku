using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minus_ChangeNumber : MonoBehaviour
{
    public Text[] texts;  // インスペクターで3つセット

    public int currentIndex = 0;

    public int correctCnt = 0;//正解の数字

    public bool isCorrect = false;//正解したか


    void Start()
    {
        ShowText(currentIndex);
    }

    void ShowText(int index)
    {
        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].gameObject.SetActive(i == index);
        }
    }

    void OnMouseDown()
    {
        // このオブジェクトがクリックされたときに呼ばれる
        currentIndex = (currentIndex + 1) % texts.Length;
        ShowText(currentIndex);

        //効果音
        FindFirstObjectByType<minus_SE_Crick>().PlaySE_Crick();


        if (currentIndex ==correctCnt)
        {
            isCorrect = true;

        }
        else
        {
            isCorrect = false;
        }


    }
}

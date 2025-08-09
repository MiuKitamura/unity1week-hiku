using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piano_HideToAppear : MonoBehaviour
{
    public float fadeSpeed = 1f; // 1秒で完全に表示

    private SpriteRenderer sr;
    private Color color;

    public piano_ChangePict ChangePict;


    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        color = sr.color;
        color.a = 0f; // 最初は完全に透明
        sr.color = color;
    }

    void Update()
    {

        if(ChangePict.isClear ==true)
        {
            // alpha値を徐々に増やす
            color.a += fadeSpeed * Time.deltaTime;
            sr.color = color;

            // 完全に表示されたら終了
            if (color.a >= 1f)
            {
                color.a = 1f;
                sr.color = color;
                enabled = false; // このスクリプトを止める
            }
        }

       
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piano_HideToAppear : MonoBehaviour
{
    public float fadeSpeed = 1f; // 1秒で完全に表示

    private SpriteRenderer sr;
    private Color color;

    public piano_ChangePict ChangePict;

    public piano_ColorChange[] ColorChange;//インスペクターでセットする　＜音符の方＞
    public piano_ToonColorChange ToonColorChanges;//ト音記号


    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        color = sr.color;
        color.a = 0f; // 最初は完全に透明
        sr.color = color;
    }

    void Update()
    {

        if (ColorChange[0].isHit == true &&
            ColorChange[1].isHit == true &&
            ColorChange[2].isHit == true &&
            ColorChange[3].isHit == true &&
            ColorChange[4].isHit == true &&
            ColorChange[5].isHit == true &&
            ColorChange[6].isHit == true &&
            ToonColorChanges.isHit == true)
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

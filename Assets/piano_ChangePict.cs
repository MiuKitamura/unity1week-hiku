using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piano_ChangePict : MonoBehaviour
{
    private SpriteRenderer sr;
    public piano_ColorChange[] ColorChange;//インスペクターでセットする　＜音符の方＞
    public piano_ToonColorChange ToonColorChanges;//ト音記号

    public bool isClear = false;
    public Sprite newSprite;//切り替える画像

    public Vector3 desiredScale = new Vector3(1, 1, 1);

    public FadeInOut fade;
    public bool isOne = false;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        //激きも書き方ゆるして…
        if (ColorChange[0].isHit == true &&
            ColorChange[1].isHit == true &&
            ColorChange[2].isHit == true &&
            ColorChange[3].isHit == true &&
            ColorChange[4].isHit == true &&
            ColorChange[5].isHit == true &&
            ColorChange[6].isHit == true &&
            ToonColorChanges.isHit ==true)
        {
            //画像変える
            sr.sprite = newSprite;
            transform.localScale = desiredScale;//サイズ合わせる

            isClear = true;

            if(isOne ==false)
            {
                isOne = true;
               
                StartCoroutine(LongWait());
                StartCoroutine(ExecuteAfterDelay());

            }

          

        }



    }
    IEnumerator ExecuteAfterDelay()
    {
        
            yield return new WaitForSeconds(4.0f); // 3秒待つ
            StartCoroutine(fade.GameEnd());
        

    }
    IEnumerator LongWait()
    {

        yield return new WaitForSeconds(1.0f); // 3秒待つ
        FindFirstObjectByType<piano_SE_pianoLong>().PlayOnceSequence();


    }



}

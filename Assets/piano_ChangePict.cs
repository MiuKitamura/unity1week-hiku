using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piano_ChangePict : MonoBehaviour
{
    private SpriteRenderer sr;
    public piano_ColorChange[] ColorChange;//�C���X�y�N�^�[�ŃZ�b�g����@�������̕���
    public piano_ToonColorChange ToonColorChanges;//�g���L��

    public bool isClear = false;
    public Sprite newSprite;//�؂�ւ���摜

    public Vector3 desiredScale = new Vector3(1, 1, 1);

    public FadeInOut fade;
    public bool isOne = false;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        //��������������邵�āc
        if (ColorChange[0].isHit == true &&
            ColorChange[1].isHit == true &&
            ColorChange[2].isHit == true &&
            ColorChange[3].isHit == true &&
            ColorChange[4].isHit == true &&
            ColorChange[5].isHit == true &&
            ColorChange[6].isHit == true &&
            ToonColorChanges.isHit ==true)
        {
            //�摜�ς���
            sr.sprite = newSprite;
            transform.localScale = desiredScale;//�T�C�Y���킹��

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
        
            yield return new WaitForSeconds(4.0f); // 3�b�҂�
            StartCoroutine(fade.GameEnd());
        

    }
    IEnumerator LongWait()
    {

        yield return new WaitForSeconds(1.0f); // 3�b�҂�
        FindFirstObjectByType<piano_SE_pianoLong>().PlayOnceSequence();


    }



}

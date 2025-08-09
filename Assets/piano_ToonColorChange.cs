using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piano_ToonColorChange : MonoBehaviour
{
    private SpriteRenderer sr;

    public bool isHit = false;

    public Sprite newSprite;//切り替える画像

    public Vector3 desiredScale = new Vector3(1, 1, 1);


    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("当たったよ");

        if (collision.CompareTag("toon") && isHit == false)
        {

            Debug.Log("色変えたよ");

            sr.sprite = newSprite;
            transform.localScale = desiredScale;//サイズ合わせる

            isHit = true;

            collision.gameObject.SetActive(false);


        }
    }
}

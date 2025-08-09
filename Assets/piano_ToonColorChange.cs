using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piano_ToonColorChange : MonoBehaviour
{
    private SpriteRenderer sr;

    public bool isHit = false;

    public Sprite newSprite;//�؂�ւ���摜

    public Vector3 desiredScale = new Vector3(1, 1, 1);


    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("����������");

        if (collision.CompareTag("toon") && isHit == false)
        {

            Debug.Log("�F�ς�����");

            sr.sprite = newSprite;
            transform.localScale = desiredScale;//�T�C�Y���킹��

            isHit = true;

            collision.gameObject.SetActive(false);


        }
    }
}

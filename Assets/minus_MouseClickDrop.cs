using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minus_MouseClickDrop : MonoBehaviour
{
    private Camera mainCamera;//変換するときよう
    private Rigidbody2D rb;

    public bool isChangeToMinus = false;//マイナスになったか

    void Start()
    {
        mainCamera = Camera.main;  // メインカメラを取得
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))  // 左クリックした瞬間
        {
            Vector2 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);

            // マウス位置にあるコライダーを探す
            Collider2D hit = Physics2D.OverlapPoint(mousePos);

            if (hit != null&&hit.gameObject == this.gameObject)
            {
                //下に落下する
                rb.gravityScale = 1.0f;

                //効果音
                FindFirstObjectByType<minus_SE_ToP>().PlaySE();

                isChangeToMinus =true;



            }
        }




    }

    //カメラ外に出たら
    void OnBecameInvisible()
    {

        Destroy(rb);
    }



}

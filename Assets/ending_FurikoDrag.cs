using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending_FurikoDrag : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Rigidbody2D endPointRigidbody;

    private bool isDragging = false;//掴んでいるか
    private Vector2 dragOffset;

    public bool isPull = false;//1回でも引っ張ったらtrue
    public float pullBorder_Y;//引っ張り判定の境界ライン値
    public int pullCnt = 0;//引っ張った回数

    public bool nowPull = false;//今引っ張られているか



    void Update()
    {
        // マウス左クリック
        if (Input.GetMouseButtonDown(0))
        {
            //マウスの画面座標をワールド座標に変換
            Vector2 mouseWorldPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);

            //マウスの位置に当たり判定があるか
            Collider2D hit = Physics2D.OverlapPoint(mouseWorldPos);

            //掴んだオブジェクトが終点なら
            if (hit != null && hit.attachedRigidbody == endPointRigidbody)
            {
                isDragging = true;
                dragOffset = endPointRigidbody.position - mouseWorldPos;

                // ドラッグ中は物理停止
                endPointRigidbody.isKinematic = true;
            }
        }

        // マウス離したとき
        if (Input.GetMouseButtonUp(0) && isDragging)
        {
            isDragging = false;

            // 物理挙動再開
            endPointRigidbody.isKinematic = false;

            if (nowPull == true)
            {
                pullCnt++;

                
            }


        }

        // ドラッグ中は終点をマウスについてくる
        if (isDragging)
        {
            Vector2 mouseWorldPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            Vector2 targetPos = mouseWorldPos + dragOffset;

            endPointRigidbody.MovePosition(targetPos);
        }


        //ボーダーまで引っ張ったら
        if (endPointRigidbody.position.y < pullBorder_Y)
        {

            isPull = true;
            nowPull = true;




        }
        else
        {
            nowPull = false;
        }


    }
}

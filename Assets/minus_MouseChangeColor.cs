using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minus_MouseChangeColor : MonoBehaviour
{
    private Camera mainCamera;
    private SpriteRenderer spriteRenderer;

    private Color originalColor;//もとの色保存


    [SerializeField] private Color changeColor = Color.yellow;//変更する色

    void Start()
    {
        mainCamera = Camera.main;
        spriteRenderer = GetComponent<SpriteRenderer>(); //オブジェクトのSpriteRendererゲット
        originalColor = spriteRenderer.color;
    }

    void Update()
    {
        //スクリーン座標をゲーム内のワールド座標に変換　　マウスの位置↓
        Vector2 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        //コライダー探す
        Collider2D hit = Physics2D.OverlapPoint(mousePos);

        if (hit != null && hit.gameObject == this.gameObject)
        {
            //このスクリプトのゲームオブジェクトなら

            spriteRenderer.color = changeColor;  // 黄色に変える
        }
        else
        {
            spriteRenderer.color = originalColor; // 元の色に戻す
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishing_FishMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public Transform mouse;
    public Transform ukiPoint;

    public fishing_SliderControl slider;

    float time = 0.0f;

    public bool fighting = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!fishing_GameManager.instance.isEnd) {
            time += Time.deltaTime;

            if(!fighting) {

                // �j������
                if(time > 1.5f) {
                    time = 0.0f;
                    rb.AddForce(new Vector2(-Random.Range(60.0f, 100.0f), 0.0f));
                }
                rb.velocity = new Vector2(rb.velocity.x * 0.997f, 0.0f);

                // �ނ莅�ɓ��B
                if(mouse.position.x < ukiPoint.position.x) {
                    fighting = true;
                    rb.velocity = Vector2.zero;

                    // ���������Ƀy�A�����g
                    ukiPoint.parent = mouse;
                    ukiPoint.position = mouse.position;

                    // �ŏ��ɗ͂�������
                    //AddForceToFish(20.0f);
                }
            }
            else {
                if(time > 0.2f) {
                    time = 0.0f;

                    slider.AddForceToSlider(-10.0f);
                }
            }
        }
    }

    public void AddForceToFish(float force) {
        rb.AddForce(new Vector2(force, 0.0f));
    }
}

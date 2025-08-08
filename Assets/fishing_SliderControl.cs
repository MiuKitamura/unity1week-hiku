using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fishing_SliderControl : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public float sliderVel = 0.0f;

    public fishing_FishMovement fish;
    public fishing_PlayerControl player;
    public Transform fishSliderPointMin, fishSliderPointMax;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();

        sliderValue = slider.value;
    }

    // Update is called once per frame
    void Update()
    {
        if(!fishing_GameManager.instance.isEnd) {
            //--------------------------------
            // �X���C�_�[�̒l�X�V
            //--------------------------------
            sliderValue += sliderVel;
            slider.value = sliderValue;

            sliderVel *= 0.99f; // ���x����

            // ���̈ʒu�X�V
            fish.transform.position = Vector2.Lerp(fishSliderPointMin.position, fishSliderPointMax.position, 1.0f - (sliderValue / 100.0f));

            // ��������
            if(sliderValue < 0.0f) { // ����
                player.turizao.transform.parent = null;
                player.turizao.constraints = RigidbodyConstraints2D.None;

                player.turizao.AddForce(new Vector2(300.0f,100.0f));

                fishing_GameManager.instance.isEnd = true;
            }
            else if(sliderValue > 100.0f) { // ����
                Rigidbody2D rb = fish.GetComponent<Rigidbody2D>();
                rb.constraints = RigidbodyConstraints2D.None;

                rb.AddForce(new Vector2(-100.0f, 700.0f));

                fishing_GameManager.instance.isEnd = true;
            }
        }
        else {

        }
    }

    public void AddForceToSlider(float force) {
        sliderVel += force * Time.deltaTime;
    }
}

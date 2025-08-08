using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishing_PlayerControl : MonoBehaviour
{
    public fishing_FishMovement fish;
    public fishing_TuriitoControl turiito;
    public fishing_SliderControl slider;

    public bool startFight = false;

    public GameObject waitImage, fightImage;
    public Transform waitAnchor, fightAnchor;
    public Rigidbody2D chairRb;

    public Animation anim;

    public Rigidbody2D turizao;

    // Start is called before the first frame update
    void Start()
    {
        waitImage.SetActive(true);
        fightImage.SetActive(false);

        turiito.SetAnchorPoint(waitAnchor);

        // 釣り上げスライダーを非表示に
        slider.gameObject.SetActive(false);

        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!fishing_GameManager.instance.isEnd) {
            // 釣り上げ開始
            if(fish.fighting && !startFight) {
                startFight = true;

                waitImage.SetActive(false);
                fightImage.SetActive(true);

                turiito.SetAnchorPoint(fightAnchor);

                // uiを表示
                slider.gameObject.SetActive(true);

                // 椅子を転がす
                chairRb.AddForce(new Vector2(-140.0f, 10.0f));
            }

            // 釣り上げ中
            if(startFight) {
                if(Input.GetMouseButtonDown(0)) {
                    slider.AddForceToSlider(10.0f);
                }
            }
        }
        else {
            if(startFight) {
                startFight = false;

                anim.Stop();
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ganman_GameManager : MonoBehaviour
{
    public float fireTime;
    public float time;

    public Text fireText;

    public ganman_Ganman you, enemy;

    public bool isEnd;

    // Start is called before the first frame update
    void Start()
    {
        fireTime = Random.Range(3.0f, 7.0f);
        time = 0.0f;

        fireText.text = "WAIT...";

        isEnd = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isEnd) return;

        time += Time.deltaTime;

        // ŽžŠÔ‚É‚È‚Á‚½
        if(time > fireTime) {
            fireText.text = "FIRE!!";
            fireText.color = Color.red;

            if(time > fireTime + 0.3f) {
                you.Down(-300.0f);
                isEnd = true;
            }
        }
    }

    public void OnClickShot() {

        if(time > fireTime && time <= fireTime + 0.5f) {
            enemy.Down(300.0f);
            isEnd = true;
        }
    }
}

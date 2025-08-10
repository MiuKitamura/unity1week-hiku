using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ganman_GameManager : MonoBehaviour
{
    public FadeInOut fade;

    public float fireTime;
    public float time;

    public Text fireText;

    public ganman_Ganman you, enemy;

    public bool isEnd;

    AudioSource source;
    public AudioClip shotSound, missSound;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();

        fireTime = Random.Range(2.0f, 6.0f);
        time = 0.0f;

        fireText.text = "ˆø‚«‹à‚ð...";

        isEnd = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isEnd) return;
        if(!fade.isStart) return;

        time += Time.deltaTime;

        // ŽžŠÔ‚É‚È‚Á‚½
        if(time > fireTime) {
            fireText.text = "ˆø‚¯!!";
            fireText.color = Color.red;

            if(time > fireTime + 0.3f) {
                enemy.Shot(-1500.0f);
                isEnd = true;

                StartCoroutine(fade.ReStart());
                source.PlayOneShot(shotSound);
            }
        }

        if(Input.GetMouseButtonDown(0)) {
            OnClickShot();
        }
    }

    public void OnClickShot() {
        if(isEnd) return;
        if(!fade.isStart) return;

        if(time > fireTime && time <= fireTime + 0.5f) {
            you.Shot(1500.0f);
            isEnd = true;

            StartCoroutine(fade.GameEnd());
            source.PlayOneShot(shotSound);
        }
        else {
            source.PlayOneShot(missSound);

            StartCoroutine(ReturnBullet());
        }
    }

    IEnumerator ReturnBullet() {
        yield return new WaitForSeconds(0.05f);

        enemy.Shot(-1500.0f);
        isEnd = true;

        StartCoroutine(fade.ReStart());
        source.PlayOneShot(shotSound);
    }
}

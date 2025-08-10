using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    public Image panel;
    public bool isStart;

    public float speed;

    public string sceneName;

    public Color startColor, endColor;

    // Start is called before the first frame update
    void Start()
    {
        isStart = false;

        // �p�l����\��
        panel.gameObject.SetActive(true);
        panel.enabled = true;

        // �F��s������
        startColor.a = 1.0f;
        panel.color = startColor;

        StartCoroutine(GameStart());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator GameStart() {

        while(true) {
            startColor.a -= Time.deltaTime * speed;
            panel.color = startColor;

            if(startColor.a < 0.0f) {
                isStart = true;
                //panel.gameObject.SetActive(false);
                panel.enabled = false;
                break;
            }

            yield return null;
        }
    }

    public IEnumerator GameEnd() {

        endColor.a = 0.0f;
        //panel.gameObject.SetActive(true);
        panel.enabled = true;

        while(true) {
            endColor.a += Time.deltaTime * speed;
            panel.color = endColor;

            if(endColor.a > 1.0f) {
                SceneManager.LoadScene(sceneName);
                break;
            }

            yield return null;
        }
    }

    public IEnumerator ReStart() {

        startColor.a = 0.0f;
        //panel.gameObject.SetActive(true);
        panel.enabled = true;

        while(true) {
            startColor.a += Time.deltaTime * speed;
            panel.color = startColor;

            if(startColor.a > 1.0f) {
                // ���݂̃V�[�����ēǂݍ���
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                break;
            }

            yield return null;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titele_BgmController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip bgmClip;

    //このオブジェクトがシーン移動すると呼ばれる
    private void Awake()
    {
        //titele_BgmControllerのオブジェクトの個数を数える
        if (FindObjectsByType<titele_BgmController>(FindObjectsSortMode.None).Length > 1)
        {
            //１より多かったら消す
            Destroy(gameObject);
            return;
        }

        //これはシーンを移動しても消えない
        DontDestroyOnLoad(gameObject);
    }

    public void PlayBGM()
    {
        if (audioSource.clip != bgmClip)
            audioSource.clip = bgmClip;

        if (!audioSource.isPlaying)
            audioSource.Play();
    }

    public void StopBGM()
    {
        if (audioSource.isPlaying)
            audioSource.Stop();
    }
}

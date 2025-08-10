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


    public void FadeOutAndStop(float duration)//音量小さくして最終的に消す
    {
        StartCoroutine(FadeOutAndStopCoroutine(duration));
    }

    private IEnumerator FadeOutAndStopCoroutine(float duration)
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume > 0f)
        {
            audioSource.volume -= startVolume * Time.deltaTime / duration;
            yield return null;
        }

        audioSource.volume = 0f;
        audioSource.Stop();
        audioSource.volume = startVolume; // 次回再生用に元の音量を戻す
    }

}

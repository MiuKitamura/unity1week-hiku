using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titele_BgmController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip bgmClip;

    //���̃I�u�W�F�N�g���V�[���ړ�����ƌĂ΂��
    private void Awake()
    {
        //titele_BgmController�̃I�u�W�F�N�g�̌��𐔂���
        if (FindObjectsByType<titele_BgmController>(FindObjectsSortMode.None).Length > 1)
        {
            //�P��葽�����������
            Destroy(gameObject);
            return;
        }

        //����̓V�[�����ړ����Ă������Ȃ�
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

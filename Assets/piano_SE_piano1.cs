using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piano_SE_piano1 : MonoBehaviour
{
    public AudioSource audioSource; // ������AudioSource������
    public AudioClip seClip;        // �Đ����������ʉ��t�@�C��

    public void PlaySE()
    {
        audioSource.PlayOneShot(seClip);
    }
}

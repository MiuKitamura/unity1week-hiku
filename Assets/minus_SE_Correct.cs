using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minus_SE_Correct : MonoBehaviour
{
    public AudioSource audioSource; // ������AudioSource������
    public AudioClip seClip;        // �Đ����������ʉ��t�@�C��

    public void PlaySE()
    {
        audioSource.PlayOneShot(seClip);
    }
}

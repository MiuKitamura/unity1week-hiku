using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titele_SeController : MonoBehaviour
{
    public AudioSource audioSource; // ������AudioSource������
    public AudioClip seClip;        // �Đ����������ʉ��t�@�C��

    public void PlaySE()
    {
        audioSource.PlayOneShot(seClip);
    }
}

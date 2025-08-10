using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piano_SE_pianoLong : MonoBehaviour
{
    public AudioSource audioSource;   // ���ʉ���炷AudioSourc
    public AudioClip[] seClip;        // ���Ԃɖ炷���ʉ��N���b�v
    public float interval = 0.5f;     // ���ʉ��̊Ԋu�i�b�j

    public void PlayOnceSequence()
    {
        StartCoroutine(PlaySequence());
    }

    private IEnumerator PlaySequence()
    {
        for (int i = 0; i < seClip.Length; i++)
        {
            audioSource.PlayOneShot(seClip[i]); // i�Ԗڂ�Clip���Đ�
            yield return new WaitForSeconds(interval);
        }
    }
}

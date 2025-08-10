using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minus_SE_Crick : MonoBehaviour
{
    public AudioSource audioSource; // ‚±‚±‚ÉAudioSource‚ğ“ü‚ê‚é
    public AudioClip seClip;        // Ä¶‚µ‚½‚¢Œø‰Ê‰¹ƒtƒ@ƒCƒ‹

    public void PlaySE_Crick()
    {
        audioSource.PlayOneShot(seClip);
    }
}

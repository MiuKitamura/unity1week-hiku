using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending_SE_Friko : MonoBehaviour
{
    public AudioSource audioSource; // ‚±‚±‚ÉAudioSource‚ğ“ü‚ê‚é
    public AudioClip seClip;        // Ä¶‚µ‚½‚¢Œø‰Ê‰¹ƒtƒ@ƒCƒ‹

    public void PlaySE()
    {
        audioSource.PlayOneShot(seClip);
    }
}

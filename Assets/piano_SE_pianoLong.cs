using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piano_SE_pianoLong : MonoBehaviour
{
    public AudioSource audioSource;   // 効果音を鳴らすAudioSourc
    public AudioClip[] seClip;        // 順番に鳴らす効果音クリップ
    public float interval = 0.5f;     // 効果音の間隔（秒）

    public void PlayOnceSequence()
    {
        StartCoroutine(PlaySequence());
    }

    private IEnumerator PlaySequence()
    {
        for (int i = 0; i < seClip.Length; i++)
        {
            audioSource.PlayOneShot(seClip[i]); // i番目のClipを再生
            yield return new WaitForSeconds(interval);
        }
    }
}

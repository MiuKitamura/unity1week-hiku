using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishing_GameManager : MonoBehaviour
{
    public bool isEnd = false;
    public FadeInOut fade;

    public static fishing_GameManager instance;

    public AudioSource source;
    public AudioClip basyaSound, clearSound;
    bool bashaFlag = false;

	private void Awake() {
        if(instance == null) {
            instance = this;
        }
	}
	// Start is called before the first frame update
	void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartBaysasya() {
        if(bashaFlag) return;

        bashaFlag = true;
        source.clip = basyaSound;
        source.loop = true;
        source.Play();
    }
}

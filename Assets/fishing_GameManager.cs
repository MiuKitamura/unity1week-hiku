using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishing_GameManager : MonoBehaviour
{
    public bool isEnd = false;

    public static fishing_GameManager instance;
	private void Awake() {
        if(instance == null) {
            instance = this;
        }
	}
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

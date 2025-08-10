using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class farm_WaterSource : MonoBehaviour
{
    public static farm_WaterSource instance;

    public FadeInOut fade;

    public farm_Pipe pipe;
    public Transform pipesParent;
    List<farm_Pipe> pipes = new List<farm_Pipe>();
    List<farm_Pipe> clearPipes = new List<farm_Pipe>();

    bool isClear = false;

	private void Awake() {
        if(instance == null) {
            instance = this;
        }
	}

	// Start is called before the first frame update
	void Start()
    {
        foreach (farm_Pipe child in pipesParent.GetComponentsInChildren<farm_Pipe>())
        {
            pipes.Add(child);
            child.Init();

            if(child.type == farm_Pipe.PipeType.Goal) {
                clearPipes.Add(child);
            }
        }

        RotValve();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // �o���u���񂳂ꂽ
    public void RotValve() {
        // ���������Z�b�g
        foreach(farm_Pipe pipe in pipes) {
            pipe.ResetWater();
        }

        // ���𗬂�
        pipe.DrawWater();

        StartCoroutine(CheckClear());
    }

    IEnumerator CheckClear() {
        yield return new WaitForSeconds(0.1f);

        isClear = true;
        foreach(farm_Pipe clear in clearPipes) {
            if(!clear.inWater) {
                isClear = false;
                break;
            }
        }

        if(isClear) {
            Debug.Log("�N���A�I�I");
            fade.StartCoroutine(fade.GameEnd());
        }
    }
}

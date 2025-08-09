using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class farm_Pipe : MonoBehaviour
{
    [System.Serializable]
    public enum PipeType {
        TypeI,
        TypeL,
        TypeT,

        Goal,
    }

    [System.Serializable]
    public enum Direct {
        Left,
        Right,
        Up,
        Bottom,
    }

    public bool tatchPipe;
    public bool inWater;

    [SerializeField] public PipeType type;
    public farm_Pipe left, right, up, bottom;
    public float rot;

    public GameObject water;

    RectTransform rect;

    // Start is called before the first frame update
    void Start()
    {
        //inWater = false;
        

        if(tatchPipe) {
            GetComponent<Image>().enabled = true;
            GetComponent<Button>().enabled = true;
        }
        else {
            GetComponent<Image>().enabled = false;
            GetComponent<Button>().enabled = false;
        }

        //water.SetActive(inWater);

        
    }

    public void Init() {
        rect = GetComponent<RectTransform>();
        rot = rect.rotation.eulerAngles.z;
        if(rot == 270) rot = -90;
        Debug.Log(rot);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool GetJoint(Direct direct) {
        int roti = Mathf.FloorToInt(rot);

        if(type == PipeType.Goal) {
            return true;
        }

        switch(direct) {
            case Direct.Left:
                if(type == PipeType.TypeI) {
                    if((int)roti == 0 || (int)roti == 180) {
                        return true;
                    }
                }
                else if(type == PipeType.TypeL) {
                    if((int)roti == 0 || (int)roti == -90) {
                        return true;
                    }
                }
                else if(type == PipeType.TypeT) {
                    if((int)roti != 90) {
                        return true;
                    }
                }
                break;
            case Direct.Right:
                if(type == PipeType.TypeI) {
                    if((int)roti == 0 || (int)roti == 180) {
                        return true;
                    }
                }
                else if(type == PipeType.TypeL) {
                    if((int)roti == 90 || (int)roti == 180) {
                        return true;
                    }
                }
                else if(type == PipeType.TypeT) {
                    if((int)roti != -90) {
                        return true;
                    }
                }
                break;
            case Direct.Up:
                if(type == PipeType.TypeI) {
                    if((int)roti == 90 || (int)roti == -90) {
                        return true;
                    }
                }
                else if(type == PipeType.TypeL) {
                    if((int)roti == -90 || (int)roti == 180) {
                        return true;
                    }
                }
                else if(type == PipeType.TypeT) {
                    if((int)roti != 0) {
                        return true;
                    }
                }
                break;
            case Direct.Bottom:
                if(type == PipeType.TypeI) {
                    if((int)roti == 90 || (int)roti == -90) {
                        return true;
                    }
                }
                else if(type == PipeType.TypeL) {
                    if((int)roti == 90 || (int)roti == 0) {
                        return true;
                    }
                }
                else if(type == PipeType.TypeT) {
                    if((int)roti != 180) {
                        return true;
                    }
                }
                break;
        }

        return false;
    }

    // …‚ðˆø‚­
    public void DrawWater() {
        inWater = true;
        water.gameObject.SetActive(true);
        
        // Œq‚ª‚Á‚Ä‚¢‚é‘¼‚Ì…˜H‚É‚à…‚ð—¬‚·
        if(left != null) {
            if(!left.inWater && left.GetJoint(Direct.Right) && GetJoint(Direct.Left)) {
                left.DrawWater();
            }
        }
        if(right != null) {
            if(!right.inWater && right.GetJoint(Direct.Left) && GetJoint(Direct.Right)) {
                right.DrawWater();
            }
        }
        if(up != null) {
            if(!up.inWater && up.GetJoint(Direct.Bottom) && GetJoint(Direct.Up)) {
                up.DrawWater();
            }
        }
        if(bottom != null) {
            if(!bottom.inWater && bottom.GetJoint(Direct.Up) && GetJoint(Direct.Bottom)) {
                bottom.DrawWater();
            }
        }
    }

    public void ResetWater() {
        inWater = false;
        water.gameObject.SetActive(false);
    }

    public void OnClick() {
        rot += 90.0f;

        if(rot > 190.0f) {
            rot = -90.0f;
        }

        rect.rotation = Quaternion.Euler(0.0f, 0.0f, rot);
        farm_WaterSource.instance.RotValve();
    }
}

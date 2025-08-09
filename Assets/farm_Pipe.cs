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

    [SerializeField] PipeType type;
    public farm_Pipe left, right, up, bottom;
    public float rot;

    public SpriteRenderer sprite;
    public GameObject water;

    // Start is called before the first frame update
    void Start()
    {
        inWater = false;

        if(tatchPipe) {
            GetComponent<Button>().enabled = true;
        }
        else {
            GetComponent<Button>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool GetJoint(Direct direct) {
        switch(direct) {
            case Direct.Left:
                if(type == PipeType.TypeI) {
                    if((int)rot == 0 || (int)rot == 180) {
                        return true;
                    }
                }
                else if(type == PipeType.TypeL) {
                    if((int)rot == 0 || (int)rot == -90) {
                        return true;
                    }
                }
                else if(type == PipeType.TypeT) {
                    if((int)rot != 90) {
                        return true;
                    }
                }
                break;
            case Direct.Right:
                if(type == PipeType.TypeI) {
                    if((int)rot == 0 || (int)rot == 180) {
                        return true;
                    }
                }
                else if(type == PipeType.TypeL) {
                    if((int)rot == 90 || (int)rot == 180) {
                        return true;
                    }
                }
                else if(type == PipeType.TypeT) {
                    if((int)rot != -90) {
                        return true;
                    }
                }
                break;
            case Direct.Up:
                if(type == PipeType.TypeI) {
                    if((int)rot == 90 || (int)rot == -90) {
                        return true;
                    }
                }
                else if(type == PipeType.TypeL) {
                    if((int)rot == -90 || (int)rot == 180) {
                        return true;
                    }
                }
                else if(type == PipeType.TypeT) {
                    if((int)rot != 0) {
                        return true;
                    }
                }
                break;
            case Direct.Bottom:
                if(type == PipeType.TypeI) {
                    if((int)rot == 90 || (int)rot == -90) {
                        return true;
                    }
                }
                else if(type == PipeType.TypeL) {
                    if((int)rot == 90 || (int)rot == 0) {
                        return true;
                    }
                }
                else if(type == PipeType.TypeT) {
                    if((int)rot != 180) {
                        return true;
                    }
                }
                break;
        }

        return false;
    }

    public void CheckInWater() {
        inWater = false;

        if(left != null) {
            if(left.GetJoint(Direct.Right) && GetJoint(Direct.Left)) {
                inWater = true;

                if(!left.inWater) {
                    left.CheckInWater();
                }
            }
        }
        if(right != null) {
            if(right.GetJoint(Direct.Left) && GetJoint(Direct.Right)) {
                inWater = true;

                if(!right.inWater) {
                    right.CheckInWater();
                }
            }
        }
        if(up != null) {
            if(up.GetJoint(Direct.Bottom) && GetJoint(Direct.Up)) {
                inWater = true;

                if(!up.inWater) {
                    up.CheckInWater();
                }
            }
        }
        if(bottom != null) {
            if(bottom.GetJoint(Direct.Up) && GetJoint(Direct.Bottom)) {
                inWater = true;

                if(!bottom.inWater) {
                    bottom.CheckInWater();
                }
            }
        }
    }

    public void OnClick() {
        rot += 90.0f;

        if(rot > 190.0f) {
            rot = -90.0f;
        }
    }
}

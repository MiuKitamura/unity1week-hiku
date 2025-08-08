using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishing_TuriitoControl : MonoBehaviour
{
    public LineRenderer line;

    public Transform anchorPoint, ukiPoint;

    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // ’Ş‚è…‚Ìü‚ğˆø‚­
        line.SetPosition(0, anchorPoint.position);
        line.SetPosition(1, ukiPoint.position);


    }

    public void SetAnchorPoint(Transform transform) {
        anchorPoint = transform;
    }
}

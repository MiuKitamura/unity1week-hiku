using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending_FrikoLine : MonoBehaviour
{
    [SerializeField] LineRenderer lineRenderer;//�ǂ̐����g����
    [SerializeField] Transform startPoint;//��
    [SerializeField] Transform endPoint;//�U��q

    // Update is called once per frame
    void Update()
    {

        var positions = new Vector3[] { startPoint.position, endPoint.position};
        lineRenderer?.SetPositions(positions);

    }
}

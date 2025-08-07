using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class titele_FurikoLineScript : MonoBehaviour
{

    [SerializeField] LineRenderer lineRenderer;//‚Ç‚Ìü‚ğg‚¤‚©
    [SerializeField] Transform startPoint;//²
    [SerializeField] Transform endPoint;//U‚èq

    // Update is called once per frame
    void Update()
    {

        var positions = new Vector3[] { startPoint.position, endPoint.position, };
        lineRenderer?.SetPositions(positions);

    }
}

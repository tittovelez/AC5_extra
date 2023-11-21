using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deteccionsuelo : MonoBehaviour
{
    public Vector3 offset;
    public float distance;
    public bool grounded;
    public LayerMask mask;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position + offset, -transform.up * distance, Color.red);
        RaycastHit hit;
        if (Physics.Raycast(transform.position + offset, -transform.up, out hit, distance, mask ))
        {
            grounded = true;
            Debug.DrawRay(transform.position + offset, -transform.up * hit.distance, Color.green);
        }
        else
        {
            grounded = false;
        }
    }
}

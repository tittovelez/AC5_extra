using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimRotation : MonoBehaviour
{
    //[SerializeField]
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetOrientation = target.position - transform.position;
        Debug.DrawRay(transform.position, targetOrientation, Color.green);

        //Orientar instantaneo
        // transform.rotation = Quaternion.LookRotation(targetOrientation);

        //Slerp
        Quaternion targetOrientationQuaternion = Quaternion.LookRotation(targetOrientation);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetOrientationQuaternion, Time.deltaTime);
    }
}

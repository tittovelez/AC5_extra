using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float Velocidad = 5f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 mover = transform.right * x + transform.forward * y;
        Debug.Log(transform.right * x + transform.forward * y);
        transform.position = transform.position + mover * Velocidad * Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody rb;
    public float SaltoVel;
    public bool enElSuelo = true;
    public int maxSaltos = 2;
    public int saltoActual = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump")) 
        {
            rb.velocity = new Vector3(0f, SaltoVel, 0f * Time.deltaTime);
            enElSuelo = false;  
            saltoActual++;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        enElSuelo = true;
        saltoActual = 0;
    }
}

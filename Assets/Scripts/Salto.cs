using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    public float salto;

    public Transform detectaPiso;
    public float distanciaPiso;

    public LayerMask mascaraPiso;

    public float gravedad = 0f;
    bool tocaPiso;
    Vector3 velocidad;
    CharacterController controller;
    // Start is called before the first frame update
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    private void Update()
    {
        tocaPiso = Physics.CheckSphere(detectaPiso.position,distanciaPiso, mascaraPiso);

        if (Input.GetButtonDown("Jump"))
        {
            velocidad.y = Mathf.Sqrt(salto * -2 * gravedad);
        }

        velocidad.y += gravedad * Time.deltaTime;
        controller.Move(velocidad * Time.deltaTime);
    }
}

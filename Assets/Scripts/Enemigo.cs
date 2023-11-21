using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float rangoDeAlerta;

    public LayerMask capaDelJugador;

    public Transform jugador;

    public float velocidad;

    bool estarAlerta = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics.CheckSphere(transform.position, rangoDeAlerta, capaDelJugador);

        if(estarAlerta == true)
        {
            //transform.LookAt(jugador);
            transform.LookAt(new Vector3(transform.position.x,jugador.position.y,jugador.position.z));
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x,jugador.position.y,jugador.position.z),velocidad * Time.deltaTime);
        }
    }
    private void OnDrawGizmos() 
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, rangoDeAlerta);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int coinCount = 0;

    private void Start()
    {
        Coin.coinCount = Coin.coinCount + 1;
        Debug.Log("Empieza el juego" + Coin.coinCount + "monedas");
    }
    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.CompareTag("Player") == true) //condicional moneda solo sea recogida jugador{
        {

        }
        Coin.coinCount--; //resta moneda recogida
        Debug.Log("recogida de moneda" + Coin.coinCount + "monedas");

        if (Coin.coinCount == 0)
        {
            Debug.Log("Se han acabado las monedas");
        }


        Destroy(gameObject);//La moneda desaparece
    }

    
 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firebullets : MonoBehaviour
{
    public GameObject bullet;
    [SerializeField]
    public float _timer = 2f;

    public int _counter;
    [SerializeField]
    private int _maxCounter = 20;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireBullets_CR());
        
    }

    // Update is called once per frame
    void Update()
    {/*
        timerCount += Time.deltaTime;

        if (timerCount>timer)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            timerCount = 0f;
        }
        */
    } 
    IEnumerator FireBullets_CR()
    {
        Debug.Log("Inicio coroutine");
        for(int i=0; i<_maxCounter; i++)
        {
            _counter++;
            Instantiate(bullet, transform.position, transform.rotation);
            yield return new WaitForSeconds(_timer);
        }
        Debug.Log("Fin coroutine");

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elfa : MonoBehaviour
{

    public GameObject player;

    public float velocidad;
    public int proximidad;

    // Start is called before the first frame update
    void Start()
    {
        velocidad = 2f;
        GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        MirarYSeguir();
        GameObject.FindGameObjectWithTag("Player");
    }

    public void MirarYSeguir()
    {
        //Mirar usando transform.LookAt:
        transform.LookAt(player.transform);

        proximidad = (int)Vector3.Distance(transform.position, player.transform.position);

        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, velocidad * Time.deltaTime);

        if (proximidad <= 2)
        {
            velocidad = 0f;
        }
        else
        {
            velocidad = 2f;
        }

    }
}
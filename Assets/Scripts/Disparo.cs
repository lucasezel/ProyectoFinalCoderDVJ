using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
 
    public GameObject balaPrefab;
    public float enfriamientoDisparo= 0.25f;
    float tiempoUltimoDisparo = 0;

    public float range = 100f;

    public Transform arma;

    public GameObject efectoImpacto_sangre;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DisparoArma();
        }
    }

    void DisparoArma()
    {
        if(Time.time - tiempoUltimoDisparo > enfriamientoDisparo)
        {
            GameObject.Instantiate(balaPrefab, transform.position, transform.rotation);
            tiempoUltimoDisparo = Time.time;
        }

        RaycastHit hit;

        if (Physics.Raycast(arma.transform.position, arma.transform.forward*-1, out hit, range))
        {
            if (hit.transform.tag == "Zombie")
            {
                Debug.Log("Dado");
                Destroy(hit.transform.gameObject);
                GameObject copia = Instantiate(efectoImpacto_sangre, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(copia, 3f);
            }

            if (hit.transform.tag == "Elfa")
            {
                Destroy(hit.transform.gameObject);
                GameObject copia = Instantiate(efectoImpacto_sangre, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(copia, 3f);
            }

        }
    }
}
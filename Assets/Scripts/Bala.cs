using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{

    public float velocidadBala = 10f;
    public float tiempoVuelo = 3f;
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce((transform.forward * -1) * velocidadBala, ForceMode.VelocityChange);
        Invoke("DestruirBala", tiempoVuelo);
    }

    void DestruirBala()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Zombie"))
        {
            Debug.Log("Zombie dado");
        }

        if (other.CompareTag("Elfa"))
        {
            Debug.Log("Elfa dado");
        }
    }
}

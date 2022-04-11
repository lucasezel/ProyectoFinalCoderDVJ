using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public Animator anim;



    // Start is called before the first frame update
    void Start()
    {
        speed = 3f;
        rotationSpeed = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();

    }

    void Movimiento()
    {
        float ver = Input.GetAxis("Vertical");

        //Movimiento vertical
        Vector3 inputJugador = new Vector3(0, 0, ver);

        //Rotacion
        transform.Rotate(new Vector3(0, 1, 0) * Input.GetAxisRaw("Horizontal") * rotationSpeed * Time.deltaTime);

        transform.Translate(inputJugador * speed * Time.deltaTime);

        if (inputJugador != Vector3.zero)
        {
            anim.SetBool("Caminando", true);
        }
        else
        {
            anim.SetBool("Caminando", false);
        }
    }
}
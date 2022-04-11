using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camaras : MonoBehaviour
{

    public GameObject camaraPrincipal;
    public GameObject camaraFrontal;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CambioDeCamara();
    }

    void CambioDeCamara()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            camaraPrincipal.SetActive(true);
            camaraFrontal.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            camaraFrontal.SetActive(true);
            camaraPrincipal.SetActive(false);
        }

    
    }
}

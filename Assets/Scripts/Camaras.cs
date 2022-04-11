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
        var inputValue = Input.inputString;
        switch (inputValue)
        {
            case ("1"):
                camaraPrincipal.SetActive(true);
                camaraFrontal.SetActive(false);
                break;
            case ("2"):
                camaraFrontal.SetActive(true);
                camaraPrincipal.SetActive(false);
                break;
            default:
                break;
        }
    }
}

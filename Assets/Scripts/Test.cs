using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{

   void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene(1);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
           ManagerDeJuego.Pausar();
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
           ManagerDeJuego.Despausar();
        }

    }

}
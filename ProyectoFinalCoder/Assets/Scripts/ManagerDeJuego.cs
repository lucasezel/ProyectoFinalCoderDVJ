using UnityEngine;

public class ManagerDeJuego : MonoBehaviour
{
    public static ManagerDeJuego instancia;

    AudioSource _audSource;

    public static int nivel;


    public Test ejemploTest;
    void Awake()
    {
        if (ManagerDeJuego.instancia == null)
        {
            ManagerDeJuego.instancia = this;
            DontDestroyOnLoad(gameObject);

            _audSource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static void Pausar()
    {
        instancia._audSource.Pause();
    }

    public static void Despausar()
    {
        instancia._audSource.UnPause();
    }
}
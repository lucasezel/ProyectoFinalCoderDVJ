using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerElfa : MonoBehaviour
{
    [SerializeField] private GameObject elfaPrefab;

    IEnumerator SpawnAfterTime(int numeroElfas)
    {
        for (int i = 0; i < numeroElfas; i++)
        {
            yield return new WaitForSeconds(5); //Espera los segundos que le pases por parametro
            Instantiate(elfaPrefab, transform.position, Quaternion.identity); //Despues, instancia el prefab del zombie
        }
    }

    private void Start()
    {
        spawnearElfa();
    }

    void spawnearElfa()
    {
        StartCoroutine(SpawnAfterTime(10)); //Esto es para que se instancie despues de cierto tiempo, le paso el numero de zombies que quiero que spawneen

    }

}
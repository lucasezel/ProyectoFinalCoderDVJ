using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   [SerializeField] private GameObject zombiePrefab;

   IEnumerator SpawnAfterTime(int numeroZombies)
   {
      for (int i = 0; i < numeroZombies; i++)
      {
         yield return new WaitForSeconds(5); //Espera los segundos que le pases por parametro
         Instantiate(zombiePrefab, transform.position, Quaternion.identity); //Despues, instancia el prefab del zombie
      }
   }

   private void Start()
   {
      spawnearZombies();
   }

   void spawnearZombies()
   {
      StartCoroutine(SpawnAfterTime(10)); //Esto es para que se instancie despues de cierto tiempo, le paso el numero de zombies que quiero que spawneen
      
   }
   
}
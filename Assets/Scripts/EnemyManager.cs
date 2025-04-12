using UnityEngine;

namespace MarcyShooter{
    public class EnemyManager : MonoBehaviour
    {

        public PlayerHealth playerHealth;
        public GameObject enemy;
        public float spawnTime = 3f;
        public Transform[] spawnPoints;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            InvokeRepeating("Spawn", spawnTime, spawnTime);
        }

        // Update is called once per frame
        void Spawn()
        {
            if(playerHealth.currentHealth <= 0f){
                return;
            }
            int spawnPointIndex = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        }
    }
}

using UnityEngine;
using System.Collections;

namespace MarcyShooter{
    public class EnemyMovement : MonoBehaviour
    {

        Transform player;
        PlayerHealth playerHealth;
        EnemyHealth enemyHealth;
        UnityEngine.AI.NavMeshAgent nav;

        void Awake()
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
            playerHealth = player.GetComponent<PlayerHealth>();
            enemyHealth = GetComponent<EnemyHealth>();
            nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0){
                nav.SetDestination(player.position);
            }
            else 
            {
                nav.enabled = false;
            }
        }
    }
}

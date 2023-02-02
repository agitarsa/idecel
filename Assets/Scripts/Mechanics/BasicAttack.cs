using System.Collections;
using System.Collections.Generic;
using Platformer.Gameplay;
using UnityEngine;
using static Platformer.Core.Simulation;

namespace Platformer.Mechanics
{
    public class BasicAttack : MonoBehaviour
    {
        [SerializeField] private float radius;
        [SerializeField] private float range;

        public void Attack(Vector2 direction)
        {
            var hits = Physics2D.CircleCastAll(transform.position, radius, direction, range);
            foreach (var hit in hits)
            {
                Debug.Log($"hit {hit.transform.gameObject.name}", hit.transform.gameObject);
                if (hit.transform.TryGetComponent(out EnemyController enemy))
                {
                    if (enemy.TryGetComponent(out Health enemyHealth))
                    {
                        enemyHealth.Decrement();
                        if (!enemyHealth.IsAlive)
                        {
                            Schedule<EnemyDeath>().enemy = enemy;
                        }
                    }
                    else
                    {
                        Schedule<EnemyDeath>().enemy = enemy;
                    }

                    //Debug.LogError("BasicAttack");
                    break;
                }
            }
        }
    }
}
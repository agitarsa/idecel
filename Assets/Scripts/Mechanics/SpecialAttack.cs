using System.Collections;
using System.Collections.Generic;
using Platformer.Gameplay;
using UnityEngine;
using static Platformer.Core.Simulation;

namespace Platformer.Mechanics
{
    public class SpecialAttack : MonoBehaviour
    {        
        public float dashSpeed;

        [Space]
        [SerializeField] private float radius;
        [SerializeField] private float range;

        public void Attack()
        {
            
        }
    }
}
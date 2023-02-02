using Platformer.Core;
using Platformer.Mechanics;
using static Platformer.Core.Simulation;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Fired when the player health reaches 0. This usually would result in a 
    /// PlayerDeath event.
    /// </summary>
    /// <typeparam name="HealthIsZero"></typeparam>
    public class HealthIsZero : Simulation.Event<HealthIsZero>
    {
        public Health health;

        public override void Execute()
        {
            if (health.TryGetComponent(out PlayerController player))
            {
                Schedule<PlayerDeath>();
            }
            //else if(health.TryGetComponent(out EnemyController enemy))
            //{
            //    Schedule<EnemyDeath>();
            //}
        }
    }
}
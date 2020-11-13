using UnityEngine;

namespace Game.Testing
{
    public class MockMoveUnity : MonoBehaviour, IMove
    {
        public float AccelerationUp { get; set; }
        public float AccelerationRight { get; set; }
        public float Speed { get; set; } = 1;

        public void Move(float addMass)
        {
            print($"{AccelerationUp * Speed},{AccelerationRight* Speed}");
        }        
    }
}


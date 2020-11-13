using Game.UnityEngine.UnityControl;
using Game.UnityEngine.UnityState;
using UnityEngine;

namespace Game.UnityEngine
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class UnityPlayer : Player
    {
        private Rigidbody2D _rigidbody;

        private void Awake() 
        {
            _rigidbody = GetComponent<Rigidbody2D>();    
        }

        private void Start() 
        {
            MoveInstance();   
            StateInstance();
        }
        protected override void MoveInstance()
        {
            movement = new Movement(transform,_rigidbody,new Rotation());
            movement.Speed = speed;
        }

        protected override void StateInstance()
        {
            state = new UnityStateHealth();
        }
    }
}

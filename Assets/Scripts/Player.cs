using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game
{
    public abstract class Player : MonoBehaviour,ITakingDamage
    {
        [SerializeField]protected float speedRun;
        [SerializeField]protected float speed;
        protected IMove movement;
        protected StateHealth state;
        protected Player()
        {
            //MoveInstance();
            //StateInstance();
        }

        public void TakeDamage(float damage) => state.RemoveHealth(damage);

        protected abstract void MoveInstance();
        protected abstract void StateInstance();
        private void FixedUpdate()
        {
            movement?.Move(0);
        }
        private void Update()
        {
            Control();
        }

        private void Control()
        {
            movement.AccelerationUp = Input.GetAxis("Vertical");
            movement.AccelerationRight = Input.GetAxis("Horizontal");
            if(Input.GetButton("Run") && state.SpeedUp())
            {
                movement.Speed = speedRun;
            }else
            {
                movement.Speed = speed;
            }
        }

        
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.UnityEngine.UnityControl
{
    public interface IRotate
    {
        void ChangeRotate(float accelerationUp,float accelerationRight);
    }
    public class Movement : IMove
    {
        private float speed;
        private Rigidbody2D rigidbody2d;
        private Transform moveObject;
        private IRotate rotation;
        public float AccelerationUp { get;set;}
        public float AccelerationRight { get; set; }
        public float Speed { get => speed; set => speed = value; }

        public Movement(Transform moveObj,Rigidbody2D rigidbody,IRotate rotation)
        {
            rigidbody2d = rigidbody;
            this.rotation = rotation;
            moveObject = moveObj;
            Initialize();
        }
        private void Initialize()
        {
            rigidbody2d.gravityScale = 0;
        }
        public void Move(float addMass)
        {
            rigidbody2d.MovePosition
            (
                moveObject.position +
                (Vector3)((Vector2.up * AccelerationUp * Speed * Time.deltaTime) + 
                (Vector2.right * AccelerationRight * Speed * Time.deltaTime))
            );
            rotation.ChangeRotate(AccelerationUp,AccelerationRight);
        }
    }
}

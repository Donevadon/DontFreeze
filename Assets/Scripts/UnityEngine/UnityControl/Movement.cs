using Game.Entities;
using UnityEngine;

namespace Game.UnityEngine.UnityControl
{
    public class Movement : IMove
    {
        private MovementSetting setting;
        private Rigidbody2D rigidbody2d;
        private Transform moveObject;
        private IRotate rotation;
        public float AccelerationUp {private get;set;}
        public float AccelerationRight {private get; set; }
        public float Speed { get => speed;private set => speed = value; }
        private float speed;

        public Movement(Transform moveObj,Rigidbody2D rigidbody,IRotate rotation,MovementSetting settings)
        {
            rigidbody2d = rigidbody;
            this.rotation = rotation;
            moveObject = moveObj;
            setting = settings;
            Initialize();
        }
        private void Initialize()
        {
            rigidbody2d.gravityScale = 0;
            Speed = setting.SpeedWalk;
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

        public void Run(bool active)
        {
            if(active) Speed = setting.SpeedRun;
            else Speed = setting.SpeedWalk;
        }
    }
}

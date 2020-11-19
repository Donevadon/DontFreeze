using System;
using Game.LivingEntity;
using Game.UnityEngine.UnityControl;
using UnityEngine;

namespace Game.UnityEngine
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class UnityPlayerUI : MonoBehaviour,ITakingDamage,IPlayerUI
    {
        private static UnityPlayerUI playerUI;
        public event EventHandler<float> DamageTaked;

        private void Awake() 
        {
            playerUI = this;    
        }

        public static UnityPlayerUI GetInstance() => playerUI;
        public IMove MoveInstance()
        {
            return new Movement(transform,
                GetComponent<Rigidbody2D>(),
                new Rotation(),
                Resources.Load<MovementSetting>("Settings/PlayerMovementSetting"));
        }

        void ITakingDamage.TakeDamage(float damage)
        {
            DamageTaked?.Invoke(this,damage);
        }
    }
}

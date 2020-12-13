using System;
using Game.Entities;
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

        void ITakingDamage.TakeDamage(float damage)
        {
            DamageTaked?.Invoke(this,damage);
        }
    }
}

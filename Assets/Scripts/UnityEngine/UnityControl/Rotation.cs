using System;
using Game.Entities;
using UnityEngine;

namespace Game.UnityEngine.UnityControl
{
    public class Rotation : IRotate
    {
        private Animator animator;
        public Rotation(Animator anim)
        {
            animator = anim;
        }
        public void ChangeRotate(float accelerationUp, float accelerationRight)
        {
            animator.SetInteger("X",(int)(Math.Ceiling((double)accelerationRight)));
            animator.SetInteger("Y",(int)(Math.Ceiling((double)accelerationUp)));
        }

    }
}
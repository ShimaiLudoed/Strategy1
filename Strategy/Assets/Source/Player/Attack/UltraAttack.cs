using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Attack
{
    public class UltraAttack : IAttack
    {
        private Animator animator;
        public void Attack(Animator animator)
        {
            Debug.Log("Use Ultra attack");
            animator.SetTrigger("Ultra");
        }
    }
}
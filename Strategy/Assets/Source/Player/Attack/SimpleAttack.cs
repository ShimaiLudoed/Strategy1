using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Attack
{
    public class SimpleAttack : IAttack
    {
        private Animator animator;

        public void Attack(Animator animator)
        {
            Debug.Log("Use Simple attack");
            animator.SetTrigger("Simple");
        }
    }
}
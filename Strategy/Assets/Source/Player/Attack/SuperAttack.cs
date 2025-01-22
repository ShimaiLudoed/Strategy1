using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Attack
{
    public class SuperAttack : IAttack
    {
        private Animator animator;
        public void Attack(Animator animator)
        {
            Debug.Log("Use SUPER attack");
            animator.SetTrigger("Super");
        }
    }
}
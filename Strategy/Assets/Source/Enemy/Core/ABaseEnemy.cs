using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    public abstract class ABaseEnemy : MonoBehaviour
    {
        [SerializeField] protected Animator animator;
        protected abstract void Attack();

        private void Start()
        {
            Attack();
        }
    }
}
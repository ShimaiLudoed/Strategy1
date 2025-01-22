using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    public class EnemyFire : ABaseEnemy
    {
        protected override void Attack()
        {
            StartCoroutine(Fire());
        }
        private IEnumerator Fire()
        {
            animator.SetTrigger("Fire");
            yield return new WaitForSeconds(1);
        }
    }
}

using Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    public class EnemySpawn : ABaseEnemy
    {
        protected override void Attack()
        {
            animator.SetTrigger("Spawn");
        }
    }
}
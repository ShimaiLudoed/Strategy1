using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Attack
{
    public class AttackPerformer
    {
        public IAttack AttackStrategy { get; set; }

        public AttackPerformer(IAttack attackStrategy)
        {
            AttackStrategy = attackStrategy;
        }
        public void ExecuteAlgoritm()
        {
            AttackStrategy.Attack();
        }
        public void SetStrategy(IAttack attack)
        {
            AttackStrategy = attack;
        }
    }
}
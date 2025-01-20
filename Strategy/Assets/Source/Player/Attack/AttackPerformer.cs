using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPerformer : MonoBehaviour
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
}

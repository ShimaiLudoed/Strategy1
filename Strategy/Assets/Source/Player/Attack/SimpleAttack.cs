using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Attack
{
    public class SimpleAttack : IAttack
    {
        public void Attack()
        {
            Debug.Log("Use Simple attack");
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Attack
{
    public class SuperAttack : IAttack
    {
        public void Attack()
        {
            Debug.Log("Use SUPER attack");
        }
    }
}
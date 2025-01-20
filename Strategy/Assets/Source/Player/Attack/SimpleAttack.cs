using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAttack : IAttack
{
    public void Attack()
    {
        Console.WriteLine("Use Simple attack");
    }
}

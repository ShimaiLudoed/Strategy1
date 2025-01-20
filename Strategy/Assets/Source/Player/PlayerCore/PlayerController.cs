using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController 
{
    //private readonly PlayerView _playerView;
    private AttackPerformer _attackPerformer;
    private StrategySwitcher _changeStrategy;

    public PlayerController(StrategySwitcher changeStrategy)
    {
        _changeStrategy = changeStrategy;
        _attackPerformer = _changeStrategy._attackPerformer;
    }

    public void Attack()
    {
        _attackPerformer.ExecuteAlgoritm();
    }
}

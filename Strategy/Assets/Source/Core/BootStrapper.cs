using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootStrapper : MonoBehaviour
{
    private List<IAttack> attackList;
    private IAttack _simple;
    private IAttack _super;
    private IAttack _ultra;
    private PlayerController _playerController;
    [SerializeField] private StrategySwitcher _changeStrategy;
    [SerializeField] private InputListener _inputListener;
    //[SerializeField] private InputListenerUI _inputUI;

    private void Start()
    {
        attackList = new List<IAttack>
        {
            _simple,
            _super,
            _ultra
        };

        _playerController = new PlayerController(_changeStrategy);
        _inputListener.Construct(_playerController);
    }
}

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StrategySwitcher : MonoBehaviour 
{
    [SerializeField] private Button[] strategyButtons; 
    private List<IAttack> _attackStrategies; 
    private AttackPerformer _attackPerformer;

    public void Construct(List<IAttack> attackStrategies)
    {
        _attackStrategies = attackStrategies;
    }

    void Awake()
    {
        _attackStrategies = new List<IAttack>
        {
            new SimpleAttack(),
            new SuperAttack(),
            new UltraAttack()
            //TODO переделать
        };


        for (int i = 0; i < strategyButtons.Length; i++)
        {
            int index = i;
            strategyButtons[i].onClick.AddListener(() => SetStrategy(index));
        }
    }

    public void SetStrategy(int index)
    {
        if (index >= 0 && index < _attackStrategies.Count)
        {
            _attackPerformer.SetStrategy(_attackStrategies[index]);
            Debug.Log($"Switched to {_attackStrategies[index].GetType().Name} Strategy");
        }
    }
}

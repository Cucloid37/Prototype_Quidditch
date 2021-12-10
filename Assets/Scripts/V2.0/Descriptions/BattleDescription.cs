using System;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace V2._0
{
    [CreateAssetMenu(fileName = "BattleDescription", menuName = "Description/BattleDescription")]
    public class BattleDescription : ScriptableObject
    {
        // понять, как реализовать передачу Description
        // каждый Description должен включать в себя возможность изменения из программы... разделить ответственность!
        // Соответственно, StartBattle принимает Descriprions - this - и принимает те объекты, которые поддаются изменению
        // А именно - Flyer и игровые объекты. Значит,
        // У нас есть разделение Spawn / Pool
        // Есть разделение на объекты FromThePeace / InsideTheBattle
        // И, кажется, они совпадают. Риали

        [SerializeField] private SquareDescription squareDescription;

        public SquareDescription Square => squareDescription;
    }
}
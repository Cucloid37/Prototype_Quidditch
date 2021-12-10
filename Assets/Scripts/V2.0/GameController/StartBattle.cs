using UnityEngine;

namespace V2._0
{
    public sealed class StartBattle
    {
        public StartBattle(BattleDescription battleDescription, PeaceDescriptions peaceDescriptions)
        {
            var factory = new GameObject("Factory").AddComponent<Factory>();
            var fieldFactory = new FieldFactory(battleDescription.Square, factory);
        }
    }
}
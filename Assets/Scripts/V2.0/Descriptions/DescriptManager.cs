using UnityEngine;

namespace V2._0
{
    public static class DescriptManager
    {
        private static BattleDescription _battle;
        private static PeaceDescriptions _peace;
        private static UIDescription _ui;

        public static BattleDescription Battle => _battle;

        public static PeaceDescriptions Peace => _peace;

        public static UIDescription UI => _ui;

        public static void SetDescriptions(BattleDescription battle, PeaceDescriptions peace, UIDescription UI)
        {
            _battle = battle;
            _peace = peace;
            _ui = UI;
        }
    }
}
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using V2._0.UI;

namespace V2._0
{ 
    public class SpawnView : MonoBehaviour, IDisposable
    {
        [SerializeField] private List<ButtonFlyerForBattle> flyerButtons;
        [SerializeField] private List<ButtonLayerForBattle> layerButtons;
        [SerializeField] private List<ButtonTeamForBattle> teamButton;

        public void Init(UnityAction<int> selectedFlyer, UnityAction<int> transformToLayer, UnityAction<int> changeTeam)
        {
            foreach (var button in flyerButtons)
            {
                button.Init(selectedFlyer);
            }

            foreach (var button in layerButtons)
            {
                button.Init(transformToLayer);
            }

            foreach (var button in teamButton)
            {
                button.Init(changeTeam);
            }
        }


        public void Dispose()
        {
            foreach (var button in flyerButtons)
            {
                button.button.onClick.RemoveAllListeners();
            }

            foreach (var button in layerButtons)
            {
                button.button.onClick.RemoveAllListeners();
            }
            
            foreach (var button in teamButton)
            {
                button.button.onClick.RemoveAllListeners();
            }
        }
    }
}
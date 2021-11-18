
    using System.Collections.Generic;
    using UnityEngine;

    public class StartGame : IStartGame, IInitialization
    {
        private List<GameObject> _firstTeam;
        private List<GameObject> _secondTeam;
        private IFactory _factory;
        private GameController _controller;

        public StartGame(IFactory factory, GameController controller)
        {
            _factory = factory;
            _controller = controller;
        }


        public void Initialization()
        {
            
        }

        public void StartBattle()
        {
            
        }
    }
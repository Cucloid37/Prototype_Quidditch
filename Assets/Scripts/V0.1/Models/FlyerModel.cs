 
        using UnityEngine;

        public class FlyerModel : IFactorSpeed
        {
            #region Property

            private string _name;
            private float _actionPoints;
            private int _force;
            private int _agility;
            private int _magicForce;

            public string Name => _name;

            public float ActionPoints => _actionPoints;

            public int Force => _force;

            public int Agility => _agility;

            public int MagicForce => _magicForce;

            public float factorSpeed { get; private set; }

            public float factorHieght { get; private set; }
            public float factorDiagonale { get; private set; }
        
            private readonly float speedMultiply = 1.1f;
            private readonly float hieghtMultiply = 0.6f;
            private readonly float diagonaleMultiply = 0.8f;

            /*public float  factorSpeed => _factorSpeed;
        public float factorHieght => _factorHieght;
        public float factorDiagonale => _factorDiagonale;*/
            #endregion

            #region Constructors

            public FlyerModel(string name, float actionPoints, int force, int agility, int magicForce)
            {
            
                _actionPoints = actionPoints;
                _force = force;
                _agility = agility;
                _magicForce = magicForce;
                _name = name;
            }

            protected FlyerModel()
            {
                
            }

            #endregion

            #region Void

            public void FactorSpeed()
            {
                factorSpeed = (float) (_force + _agility) * speedMultiply;
            }

            public void FactorHeight()
            {
                factorHieght = (float) _force * hieghtMultiply;
            }

            public void FactorDiagonal()
            {
            
                factorDiagonale = (float) _agility * diagonaleMultiply;
            }

            public void SetForce(int force)
            {
                _force = force;
            }
        
            public void SetAgility(int agility)
            {
                _agility = agility;
            }

            public void SetMagicForce(int magicForce)
            {
                _magicForce = magicForce;
            }

            public void SetActionPoints(float actionPoints)
            {
                _actionPoints = actionPoints;
            }

            #endregion
        
        
        }
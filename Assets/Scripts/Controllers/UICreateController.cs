
    using System;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    internal sealed class UICreateController
    {
        private List<IFlyer> _listTeam;
        private Data _data;
        private FlyerType _type;
        private string _name;
        private float _actionPoints;
        private int _force;
        private int _agility;
        private int _magicForce;
        
        private int _count;
        private int _maxCount;

        public UICreateController(Data data, List<IFlyer> listTeam)
        {
            _data = data;
            _listTeam = listTeam;
        }
        
        public void Initialization(UICreateModel model)
        {
            _name = model.InputName.text;
            _actionPoints = Convert.ToSingle(model.APCount.text);
            _force = Convert.ToInt32(model.ForceCount.text);
            _agility = Convert.ToInt32(model.AgilityCount.text);
            _magicForce = Convert.ToInt32(model.MagicCount.text);
            _maxCount = Convert.ToInt32(model.CpCount.text);
        }
        
        public void MinusCount(Text count)
        {
            _count = int.Parse(count.text);
            if (_count > 0)
            {
                _count--;
                _maxCount++;
                count.text = _count.ToString();
            }
        }

        public void PlusCount(Text count)
        {
            Debug.Log($"MaxCount was{_maxCount}");
            _count = int.Parse(count.text);
            if (_maxCount > 0)
            {
                _count++;
                _maxCount--;
                count.text = _count.ToString();
                Debug.Log($"Is now a {_maxCount}");
            }
            
        }

        public void SetType(FlyerType type)
        {
            _type = type;
            Debug.Log($"Now type is {_type}");
        }
        
        public void CreateFlyer()
        {
            var flyerObject = _data.Flyer.GetFlyer(_type);
            flyerObject.SetModel(_name, _actionPoints, _force, _agility, _magicForce);
            _listTeam.Add(flyerObject);
            
            foreach (var t in _listTeam)
            {
                Debug.LogWarning($"{t}");
            }
            
        }
        
    }

using System.Collections.Generic;
using UnityEngine;

namespace V2._0
{
    public class FieldPresenter
    {
        private List<SquareView> _viewList;
        private List<SquareModel> _modelList;

        public List<SquareModel> Models => _modelList;
        public List<SquareView> Views => _viewList;

        public FieldPresenter(List<SquareView> viewList, List<SquareModel> modelList)
        {
           _viewList = viewList;
            _modelList = modelList;
        }

    }
}
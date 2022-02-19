using System.Collections.Generic;
using UnityEngine;

namespace V2._0
{
    public class FieldPresenter
    {
        private List<SquareView> _viewList;
        private List<SquareModel> _modelList;

        public FieldPresenter(List<SquareView> viewList, List<SquareModel> modelList)
        {
           _viewList = viewList;
            _modelList = modelList;
        }

    }
}
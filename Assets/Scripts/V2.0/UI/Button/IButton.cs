using System;
using UnityEngine;

namespace V2._0.UI
{
    
    public interface IButton
    {
        Vector3 _transform { get; }
        ButtonType _buttonType { get; }
    }
}
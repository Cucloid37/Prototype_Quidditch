using System.Data;
using System.IO;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Data/Data")]
public class Data : ScriptableObject
{
    [SerializeField] private string _squareData;
    [SerializeField] private string _UICreateData;
    [SerializeField] private string _UIStartData;
    [SerializeField] private string _flyerData;
    private SquareData _square;
    private UICreateData _uiCreate;
    private UIStartData _uiStart;
    private FlyerData _flyer;

    public SquareData Square
    {
        get
        {
            if (_square == null)
            {
                
                _square = Load<SquareData>("Data/" + _squareData);
                if (_square == null)
                {
                    throw new DataException($"{_square}");
                }
            }
            
            return _square;
        }
    }
    
    public UICreateData UICreate
    {
        get
        {
            if (_uiCreate == null)
            {
                
                _uiCreate = Load<UICreateData>("Data/" + _UICreateData);
                if (_uiCreate == null)
                {
                    throw new DataException($"{_uiCreate}");
                }
            }
            
            return _uiCreate;
        }
    }
    
    public UIStartData UIStart
    {
        get
        {
            if (_uiStart == null)
            {
                
                _uiStart = Load<UIStartData>("Data/" + _UIStartData);
                if (_uiStart == null)
                {
                    throw new DataException($"{_uiStart}");
                }
            }
            
            return _uiStart;
        }
    }
    
    public FlyerData Flyer
    {
        get
        {
            if (_flyer == null)
            {
                
                _flyer = Load<FlyerData>("Data/" + _flyerData);
                if (_flyer == null)
                {
                    throw new DataException($"{_flyer}");
                }
            }
            
            return _flyer;
        }
    }
        
    private static T Load<T>(string resourcesPath) where T : Object =>
        Resources.Load<T>(Path.ChangeExtension(resourcesPath, null));
}
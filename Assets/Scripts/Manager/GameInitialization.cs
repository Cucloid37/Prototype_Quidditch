using UnityEngine;

public class GameInitialization
{
    private Data _data;
    private GameObject _canvas;

    public GameInitialization(Data data, GameObject canvas)
    {
        
        _data = data;
        _canvas = canvas;
        var factory = new GameObject("Factory").gameObject.AddComponent<Factory>();
        var fieldFactory = new FieldFactory(data.Square, factory);
        fieldFactory.CreateField();
        
        var uiFactory = new UIFactory(factory, canvas);
        var uiController = new UIController(data, uiFactory);
        var startCanvas = uiFactory.CreateUIObject(data.UIStart.CreateCanvas);
        var startUI = new UIStartModel(startCanvas, uiController);
        startUI.Initialization();


        /*var Canvas = UIFactory.CreateUIObject(data.UICreate.CreateCanvas);

       
        var UICreateModel = new UICreateModel(Canvas, UIcontroller);
        UICreateModel.Initialization();*/

    }
}
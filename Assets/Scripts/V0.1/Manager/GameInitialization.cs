using UnityEngine;

public class GameInitialization
{
    private Data _data;
    private GameObject _canvas;

    public GameInitialization(Data data, Controllers controllers, GameObject canvas)
    {
        
        _data = data;
        _canvas = canvas;
        var inputInitialization = new InputInitialization();
        var factory = new GameObject("Factory").gameObject.AddComponent<Factory>();
        var fieldFactory = new FieldFactory(data.Square, factory);
        var uiFactory = new UIFactory(factory, canvas);
        var uiController = new UIController(data, uiFactory);
        var startCanvas = uiFactory.CreateUIObject(data.UIStart.CreateCanvas);

        controllers.Add(inputInitialization);
        controllers.Add(new InputController(inputInitialization.GetInput()));
        controllers.Add(new UIStartModel(startCanvas, uiController));

        fieldFactory.CreateField();

    }
}
using AplosUserInterfaceEventHub;
using UnityEngine;

public class TestGameHUDController : MonoBehaviour
{

    [SerializeField] private TestGameHUDView _view;

    private void Start()
    {
        IUserInterfaceEventHubCollection _eventHubCollection = GameManager.Instance.UIEventHub;

        // Register method actions to event hub registry
        _eventHubCollection.RegisterEvent(TestGameHUDControllerActions.ShowHUD, _view.ShowHUD);
        _eventHubCollection.RegisterEvent(TestGameHUDControllerActions.HideHUD, _view.HideHUD);
    }

}

public class TestGameHUDControllerActions
{
    public const string ShowHUD = "ShowHUD";
    public const string HideHUD = "HideHUD";
}
using UnityEngine;

public class PlayerTriggerCollisionHandler : MonoBehaviour
{

    private bool _isHUDVisible = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ToggleHUDDisplay();
            Debug.Log("Player entered trigger zone, HUD should be visible.");
        }
    }

    private void ToggleHUDDisplay()
    {
        _isHUDVisible = !_isHUDVisible;
        var eventHUB = GameManager.Instance.UIEventHub;

        if (_isHUDVisible)
            eventHUB.TriggerEvent("ShowHUD");
        else
            eventHUB.TriggerEvent("HideHUD");
    }

}
using UnityEngine;

public class TestGameHUDView : MonoBehaviour
{

    [SerializeField] private GameObject _contentGroup;

    public void ShowHUD()
        => _contentGroup.SetActive(true);

    public void HideHUD()
        => _contentGroup.SetActive(false);

}
using AplosUserInterfaceEventHub;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public UserInterfaceEventHub UIEventHub;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

}
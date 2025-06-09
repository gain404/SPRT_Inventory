using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [SerializeField] private UIMainMenu uiMainMenu;
    public UIMainMenu UIMainMenu => uiMainMenu;
    [SerializeField] private UIStatus uiStatus;
    public UIStatus UIStatus => uiStatus;
    [SerializeField] private UIInventory uiInventory;
    public UIInventory UIInventory => uiInventory;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if(Instance != this)
            {
                Destroy(gameObject);
            }
        }
    }
}

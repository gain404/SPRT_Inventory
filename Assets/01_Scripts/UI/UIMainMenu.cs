using TMPro;
using UnityEngine;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI idText;
    [SerializeField] private TextMeshProUGUI LevelCount;
    [SerializeField] private TextMeshProUGUI Gold;

    public GameObject statusPanel;
    public GameObject inventoryPanel;
    
    private UIManager uiManager;

    private void Awake()
    {
        uiManager = UIManager.Instance;
        SetId();
        SetLevelCount();
        SetGold();
    }
    
    private void SetId()
    {
        idText.text = uiManager.character.id;
    }

    private void SetLevelCount()
    {
        LevelCount.text = uiManager.character.level.ToString();
    }

    private void SetGold()
    {
        Gold.text = uiManager.character.gold.ToString();
    }

    public void OnStatusButton()
    {
        statusPanel.SetActive(true);
    }

    public void OnInventoryButton()
    {
        inventoryPanel.SetActive(true);
    }
}

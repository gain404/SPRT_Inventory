using TMPro;
using UnityEngine;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI idText;
    [SerializeField] private TextMeshProUGUI LevelCount;
    [SerializeField] private TextMeshProUGUI Gold;

    public GameObject statusPanel;
    public GameObject inventoryPanel;
    
    private GameManager gameManager;

    private void Awake()
    {
        gameManager = GameManager.Instance;
        SetId();
        SetLevelCount();
        SetGold();
    }
    
    private void SetId()
    {
        idText.text = gameManager.character.id;
    }

    private void SetLevelCount()
    {
        LevelCount.text = gameManager.character.level.ToString();
    }

    private void SetGold()
    {
        Gold.text = gameManager.character.gold.ToString();
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

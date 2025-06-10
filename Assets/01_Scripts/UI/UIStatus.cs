using TMPro;
using UnityEngine;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI attackTxt;
    [SerializeField] private TextMeshProUGUI defTxt;
    [SerializeField] private TextMeshProUGUI healthTxt;
    [SerializeField] private TextMeshProUGUI fatalTxt;

    [SerializeField] private GameObject statusPanel;
    
    private GameManager gameManager;
    
    private void Awake()
    {
        gameManager = GameManager.Instance;
    }

    private void Start()
    {
        SetStatus();
    }
    
    private void SetStatus()
    {
        attackTxt.text = gameManager.character.status.attack.ToString();
        defTxt.text = gameManager.character.status.defense.ToString();
        healthTxt.text = gameManager.character.status.stamina.ToString();
        fatalTxt.text = gameManager.character.status.fatality.ToString();
    }

    public void OnBackButton()
    {
        statusPanel.SetActive(false);
    }
    
}

using TMPro;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class UIFollowCursor : MonoBehaviour
{
    [SerializeField] private Vector2 offset;
    private RectTransform rectTransform;

    [SerializeField] private TextMeshProUGUI itemname;
    [SerializeField] private TextMeshProUGUI itemdiscription;
    
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        Vector2 mousePos = Input.mousePosition;
        rectTransform.position = mousePos + offset;
    }

    public void SetText(string name, string description)
    {
        itemname.text = name;
        itemdiscription.text = description;
    }
    
}

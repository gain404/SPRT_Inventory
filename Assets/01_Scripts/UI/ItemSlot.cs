using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public ItemData itemData;
    
    public Image icon;
    public UIFollowCursor cursorObject;
    public GameObject equipObject;
    
    private int clickCount = 0;
    
    private void Awake()
    {
        icon = GetComponent<Image>();
    }
    
    public void Initialize(ItemData data, UIFollowCursor uiFollowCursor)
    {
        itemData = data;
        cursorObject = uiFollowCursor;
        icon.sprite = data.IconImage;
        icon.gameObject.SetActive(true);
    }
    
    //아이템 슬롯에 커서를 가져다 대면 아이템 이름과 슬롯이 뜨게
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (itemData == null) return;
        cursorObject.SetText(itemData.ItemName, itemData.description);
        cursorObject.gameObject.SetActive(true);
    }

    public void OnEquipItem()
    {
        clickCount++;
        
        if (clickCount == 1)
        {
            equipObject.SetActive(true);
            itemData.isEquipped = true;
            ChangeItemStatus();
        }
        else if (clickCount == 2)
        {
            equipObject.SetActive(false);
            itemData.isEquipped = false;
            DisChanageItemStatus();
            
            clickCount = 0;
        }
    }

    private void ChangeItemStatus()
    {
        switch (itemData.itemType)
        {
            case ItemType.Attack:
                GameManager.Instance.character.status.attack += itemData.itemStatus;
                break;
            case ItemType.Defense:
                GameManager.Instance.character.status.defense += itemData.itemStatus;
                break;
            case ItemType.Stamina:
                GameManager.Instance.character.status.stamina += itemData.itemStatus;
                break;
            case ItemType.Object:
                break;
        }
    }

    private void DisChanageItemStatus()
    {
        switch (itemData.itemType)
        {
            case ItemType.Attack:
                GameManager.Instance.character.status.attack -= itemData.itemStatus;
                break;
            case ItemType.Defense:
                GameManager.Instance.character.status.defense -= itemData.itemStatus;
                break;
            case ItemType.Stamina:
                GameManager.Instance.character.status.stamina -= itemData.itemStatus;
                break;
            case ItemType.Object:
                break;
        }
    }
    
    public void OnPointerExit(PointerEventData eventData)
    {
        cursorObject.gameObject.SetActive(false);
    }
}

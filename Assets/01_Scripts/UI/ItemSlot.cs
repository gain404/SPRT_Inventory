using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public ItemData itemData;
    
    public Image icon;
    public UIFollowCursor cursorObject;

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

    public void OnPointerExit(PointerEventData eventData)
    {
        cursorObject.gameObject.SetActive(false);
    }
}

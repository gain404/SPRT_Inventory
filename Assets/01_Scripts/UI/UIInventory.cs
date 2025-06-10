using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private GameObject InventoryPanel;
    [SerializeField] private List<ItemData> itemList;
    [SerializeField] private Transform slotParent;
    [SerializeField] private UIFollowCursor cursorObject;

    private void Start()
    {
        OnItemSlot();
    }
    
    //추가된 아이템 리스트 슬롯에 할당
    private void OnItemSlot()
    {
        int count = Mathf.Min(itemList.Count, slotParent.childCount);
        for (int i = 0; i < count; i++)
        {
            ItemSlot slot = slotParent.GetChild(i).GetComponent<ItemSlot>();
            slot.Initialize(itemList[i], cursorObject);
        }
    }
    
    public void OnBackButton()
    {
        InventoryPanel.SetActive(false);
    }
}

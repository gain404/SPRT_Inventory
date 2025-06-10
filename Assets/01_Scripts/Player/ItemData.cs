using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{
    attack,
    defense,
    Object
}

[CreateAssetMenu]
public class ItemData : ScriptableObject
{
    public string ItemName;
    public Sprite IconImage;
    
    public string description;
    public ItemType itemType;

    private ItemSlot itemSlot;
}

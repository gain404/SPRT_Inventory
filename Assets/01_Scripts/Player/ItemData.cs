using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{
    Attack,
    Defense,
    Object,
    Stamina
}

[CreateAssetMenu]
public class ItemData : ScriptableObject
{
    public string ItemName;
    public Sprite IconImage;
    
    public string description;
    public ItemType itemType;
    public bool isEquipped;
    public int itemStatus;
}

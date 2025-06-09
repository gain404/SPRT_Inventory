using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public string discription;
    public ItemType itemType;
}

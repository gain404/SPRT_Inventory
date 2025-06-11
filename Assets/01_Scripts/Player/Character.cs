using UnityEngine;

[System.Serializable]
public class Status
{
    public int attack = 10;
    public int defense = 10;
    public int stamina = 10;
    public int fatality = 10;
}

public class Character : MonoBehaviour
{
    public string id;
    public int level;
    public int gold;
    public Status status;
    
    private void Awake()
    {
        GameManager.Instance.character = this;
    }
}

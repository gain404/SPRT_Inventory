using UnityEngine;

[System.Serializable]
public class Status
{
    public int attack;
    public int defense;
    public int stamina;
    public int fatality;
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

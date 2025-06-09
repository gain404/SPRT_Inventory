using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}

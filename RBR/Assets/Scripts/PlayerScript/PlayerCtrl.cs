using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public PlayerData playerData;
}

[System.Serializable]
public class PlayerData
{
    public float X;
    public float Y;
    public float Hp;
    public bool[] isCleared;
}
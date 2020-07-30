using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinData : MonoBehaviour
{
    public delegate void UpdateCoin(int coinAmount);

    public static UpdateCoin myCoinUpdate;

    public const string key_Coin = "Key_Coin";
    
    public int coin;

    private void Start()
    {
        coin = PlayerPrefs.GetInt(key_Coin, 0);
    }

    public void AddCoin(int amount)
    {
        coin += amount;
        PlayerPrefs.SetInt(key_Coin,coin);
        myCoinUpdate(coin);
    }

    [ContextMenu("Test")]void Test()
    {
        AddCoin(10);
    }
}

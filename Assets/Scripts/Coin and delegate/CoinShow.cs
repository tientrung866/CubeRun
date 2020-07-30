using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinShow : MonoBehaviour
{
    [SerializeField] private Text CoinUI;
    // Start is called before the first frame update
    void Start()
    {
        CoinData.myCoinUpdate += UpdateCoin;
    }

    // Update is called once per frame
    void UpdateCoin(int coin)
    {
        CoinUI.text = coin.ToString("0");
    }
}

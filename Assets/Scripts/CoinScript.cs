using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour {

    int coin = 0;
    int lives = 0;
    public static CoinScript instance_ = null;
    //public Text coinText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        calculateCoin();
      	
	}
    public void calculateCoin()
    {
        coin = coin + 10;
        checkCoinNumber(coin);
      //  coinText.text = "Coins = " + coin;

    }

    void checkCoinNumber(int coin)
    {
       if(coin == 100) {

            lives++;
            coin = 0;       
       }
    }
}

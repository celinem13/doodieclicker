using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class BuyDoodlers : MonoBehaviour
{
    public BuyDoodles doodles;
    public float currentPrice, clickPower;
    private float powerOf;
    private float basePrice;
    private int numOfDoodlerAccessories = 0;
    public Text doodleAccessories;
    public Text priceOfAccessories;

    public void PurchaseUpgrade()
    {
        if(doodles.totalDoodles >= currentPrice)
        {
            doodles.totalDoodles -= currentPrice;
            powerOf++;
            doodles.amountPerClick += clickPower;
            currentPrice = Mathf.Round(basePrice * Mathf.Pow(1.75f, powerOf));
            numOfDoodlerAccessories++;
            PlayerPrefs.SetInt("Accessories Text", numOfDoodlerAccessories);
            PlayerPrefs.SetFloat("PriceOfAccessories", currentPrice);
        }
    }

    public void Start()
    {
        doodleAccessories.text = numOfDoodlerAccessories.ToString();
        basePrice = currentPrice;
        priceOfAccessories.text = "$25";
    }

    public void GetDoodles()
    {
        doodleAccessories.text = PlayerPrefs.GetInt("Accessories Text").ToString();
    }

    public void GetAccessoriesPrices()
    {
        priceOfAccessories.text = "$" + PlayerPrefs.GetFloat("PriceOfAccessories").ToString();
    }

    public void UpdateText()
    {
        doodles.score.text = PlayerPrefs.GetFloat("Total Doodles").ToString();
    }
}

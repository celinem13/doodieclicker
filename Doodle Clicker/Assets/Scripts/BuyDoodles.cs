using UnityEngine;
using UnityEngine.UI;

public class BuyDoodles : MonoBehaviour
{
    public float totalDoodles = 0.0f;
    public float amountPerClick = 1.0f;
    public Text score;

    public void Start()
    {
        score.text = totalDoodles.ToString();
    }

    public void AddDoodles()
    {
        totalDoodles += amountPerClick;
        PlayerPrefs.SetFloat("Total Doodles", totalDoodles);
    }

    public void GetDoodles()
    {
        score.text = PlayerPrefs.GetFloat("Total Doodles").ToString();
    }
}

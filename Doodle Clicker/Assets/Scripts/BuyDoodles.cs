using UnityEngine;
using UnityEngine.UI;

public class BuyDoodles : MonoBehaviour
{
    public Text score;

    public void Start()
    {
        score.text = DoodleCounterManager.totalDoodles.ToString();
    }

    public void AddDoodles()
    {
        DoodleCounterManager.totalDoodles++;
        PlayerPrefs.SetInt("Total Doodles", DoodleCounterManager.totalDoodles);
    }

    public void GetDoodles()
    {
        score.text = PlayerPrefs.GetInt("Total Doodles").ToString();
    }
}

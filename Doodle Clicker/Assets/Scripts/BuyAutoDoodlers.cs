using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyAutoDoodlers : MonoBehaviour
{
    public bool addingDoodles = false;
    public int increaseAmount = 1;
    public BuyDoodles doodles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!addingDoodles)
        {
            addingDoodles = true;
            StartCoroutine(MakeAutoDoodles());
        }
    }

    IEnumerator MakeAutoDoodles()
    {
        doodles.totalDoodles += increaseAmount;
        yield return new WaitForSeconds(1);
        addingDoodles= false;
    }
}

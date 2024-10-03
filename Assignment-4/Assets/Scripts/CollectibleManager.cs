using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleManager : MonoBehaviour
{
    public int pumpkinCount;
    public TextMeshProUGUI pumpkinText;
    public GameObject winTextObject;
    // Start is called before the first frame update
    void Start()
    {
        pumpkinCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pumpkinText.text = "Pumpkin count: " + pumpkinCount.ToString();
        
        if(pumpkinCount >= 1)
        {
            pumpkinText.text = "You're safe!";
        }
    }
}

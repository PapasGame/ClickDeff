using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.IO;

public class countMoney : MonoBehaviour
{
    public double count = 0;
    public double inc = 1;

    private static Dictionary<string, int> arrayOfLetters;
    void Start()
    {
        var Data = File.ReadAllText(@"Assets\Data\moneyIndicators.json");
        arrayOfLetters = JsonConvert.DeserializeObject<Dictionary<string, int>>(Data);//parsing

        GetComponent<Text>().text = count.ToString();
        InvokeRepeating("incrementMoney", 1, 0.5f);
    }

    private void incrementMoney()
    {
        count += inc;
        GetComponent<Text>().text = makeFormat(count);
        inc += inc;
    }

    private string makeFormat(double count)
    {
        string stringCount = count.ToString();

        foreach (var item in arrayOfLetters)
        {
            if (stringCount.Length > item.Value)
            {
                if (stringCount.Length == 4)
                {
                    stringCount = stringCount.Insert(stringCount.Length - item.Value, ",");  //insert ","
                }
                else
                {
                    stringCount = stringCount.Insert(stringCount.Length - item.Value, ".");  //insert "."
                    stringCount = stringCount.Substring(0, stringCount.Length - (item.Value - 2)) + item.Key; //delete all after .00 + add letter
                }                

                Debug.Log(count + " " + stringCount);

                return stringCount;
            }
        }
        return stringCount;
    }
}

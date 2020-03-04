using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.IO;

public class money : MonoBehaviour
{
    void Start()
    {
        InvokeRepeating("formatOutputMoney", 1, 0.1f);
    }

    private void formatOutputMoney()
    {
        GetComponent<Text>().text = makeFormat(info.money);
    }

    public static string makeFormat(double count)
    {
        string stringCount = count.ToString();

        if (count >= 999999)
        {
            stringCount = String.Format("{0:F0}", count);
            stringCount.Replace(" ",string.Empty);
            Debug.Log(count + " " + stringCount);
        }

        foreach (var item in info.arrayOfLetters)
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

               // Debug.Log(count + " " + stringCount);

                return stringCount;
            }
        }
        return stringCount;
    }
}

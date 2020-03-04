using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.IO;

public class info : MonoBehaviour
{
    public static double money { get; set; } = 0;   
    public static string nameOfBookmarks { get; set; }
    public static Sprite previoslyImg { get; set; }
    public static GameObject previoslyWindow { get; set; }

    public Sprite first;

    public GameObject firstWindow;


    public static Dictionary<string, int> arrayOfLetters;
    private void Awake()
    {
        nameOfBookmarks = "weapon";
        previoslyImg = GameObject.Find("weapon").GetComponent<Image>().sprite;
        GameObject.Find("weapon").GetComponent<Image>().sprite = first;
        firstWindow.SetActive(true);

        previoslyWindow = firstWindow;


        var Data = File.ReadAllText(@"Assets\Data\moneyIndicators.json");
        arrayOfLetters = JsonConvert.DeserializeObject<Dictionary<string, int>>(Data);//parsing
    }

}

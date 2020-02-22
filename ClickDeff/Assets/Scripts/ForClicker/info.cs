using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class info : MonoBehaviour 
{
    public static string nameOfBookmarks { get; set; }
    public static Sprite previoslyImg { get; set; }
    public static GameObject previoslyWindow { get; set; }

    public Sprite first;

    public GameObject firstWindow;

    private void Start()
    {
        nameOfBookmarks = "weapon";
        previoslyImg = GameObject.Find("weapon").GetComponent<Image>().sprite;
        GameObject.Find("weapon").GetComponent<Image>().sprite = first;
        firstWindow.SetActive(true);

        previoslyWindow = firstWindow;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info : MonoBehaviour 
{
    public static string nameOfBookmarks { get; set; }
    public static Sprite previoslyImg { get; set; }
    public Sprite first;

    private void Start()
    {
        nameOfBookmarks = "game";
        previoslyImg = GameObject.Find("game").GetComponent<SpriteRenderer>().sprite;
        GameObject.Find("game").GetComponent<SpriteRenderer>().sprite = first;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeBookmarks : MonoBehaviour
{
    //public GameObject targetWindow;
    public Sprite activeImg;
    public GameObject activeWindow;

    private void OnMouseDown()
    {
        //change bookmarks
        GameObject.Find(info.nameOfBookmarks).GetComponent<SpriteRenderer>().sprite = info.previoslyImg;
        info.previoslyImg = GetComponent<SpriteRenderer>().sprite;
        GetComponent<SpriteRenderer>().sprite = activeImg;
        info.nameOfBookmarks = name;

        //change menu
        info.previoslyWindow.SetActive(false);
        activeWindow.SetActive(true);
        info.previoslyWindow = activeWindow;


        Debug.Log(gameObject.name + " " + info.nameOfBookmarks);
    }

}

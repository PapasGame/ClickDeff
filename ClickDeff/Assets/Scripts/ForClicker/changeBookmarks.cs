using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeBookmarks : MonoBehaviour
{
    public Sprite activeImg;
    public GameObject activeWindow;

    private void OnMouseDown()
    {
        //change bookmarks
        //GameObject.Find(info.nameOfBookmarks).GetComponent<SpriteRenderer>().sprite = info.previoslyImg;
        //info.previoslyImg = GetComponent<SpriteRenderer>().sprite;
        //GetComponent<Image>().sprite = activeImg;
        //GetComponent<SpriteRenderer>().sprite = activeImg;
        //info.nameOfBookmarks = name;

        //change menu
        //info.previoslyWindow.SetActive(false);
        //activeWindow.SetActive(true);
        //info.previoslyWindow = activeWindow;


        Debug.Log(gameObject.name + " " + info.nameOfBookmarks);
    }
    

    public void change()
    {
        Debug.Log(gameObject.name);
        GameObject.Find(info.nameOfBookmarks).GetComponent<Image>().sprite = info.previoslyImg;
        info.previoslyImg = GetComponent<Image>().sprite;
        GetComponent<Image>().sprite = activeImg;
        info.nameOfBookmarks = name;

        info.previoslyWindow.SetActive(false);
        activeWindow.SetActive(true);
        info.previoslyWindow = activeWindow;

    }

}

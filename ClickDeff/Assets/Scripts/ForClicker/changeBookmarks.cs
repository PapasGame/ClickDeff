using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeBookmarks : MonoBehaviour
{
    //public GameObject targetWindow;
    public Sprite disableImg, activeImg;

    private void OnMouseDown()
    {
        /*transform.parent.parent.gameObject.SetActive(false);
        targetWindow.SetActive(true);
        gameObject.SetActive(true);*/

        //change bookmarks
        GameObject.Find(info.nameOfBookmarks).GetComponent<SpriteRenderer>().sprite = info.previoslyImg;
        info.previoslyImg = GetComponent<SpriteRenderer>().sprite;
        GetComponent<SpriteRenderer>().sprite = activeImg;
        info.nameOfBookmarks = name;

        //change menu


        Debug.Log(gameObject.name + " " + info.nameOfBookmarks);
    }

}

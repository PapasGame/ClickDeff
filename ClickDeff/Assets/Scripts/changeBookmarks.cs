using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeBookmarks : MonoBehaviour
{
    public GameObject target;
    private void OnMouseDown()
    {
        Debug.Log("click works");
        transform.parent.parent.gameObject.SetActive(false);
        target.SetActive(true);
    }
}

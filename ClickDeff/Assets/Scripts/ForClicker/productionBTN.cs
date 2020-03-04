using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class productionBTN : MonoBehaviour
{
    public float earnMoney;
    public float costImprove;

    private float coefficient;
    private float level;
    private float baseCost;

    private void Start()
    {
        baseCost = costImprove;
        level = 1;
        coefficient = 1.04f;

        foreach (Transform child in GetComponentsInChildren<Transform>())
        {
            if (child.name == "earning")
            {
                child.GetComponent<Text>().text = money.makeFormat(earnMoney);
            }
            if (child.name == "cost")
            {
                child.GetComponent<Text>().text = money.makeFormat(costImprove);
            }
        }
    }

    public void getMoney()
    {
        info.money += earnMoney;        
    }

    public void upgradeProduction()
    {
        if (info.money < costImprove)
        {

        }
        else
        {
            info.money -= costImprove;
            earnMoney = Mathf.Ceil(earnMoney * 1.5f);
            costImprove = Mathf.Ceil(baseCost * Mathf.Pow(coefficient, level));
            level++;

            Debug.Log("ДОБЫЧА - " + earnMoney + " | СТОИМОСТЬ УЛУЧШЕНИЯ - " + costImprove);

            foreach (Transform child in GetComponentsInChildren<Transform>())
            {
                if (child.name == "earning")
                {
                    child.GetComponent<Text>().text = money.makeFormat(earnMoney);
                }
                if (child.name == "cost")
                {
                    child.GetComponent<Text>().text = money.makeFormat(costImprove);
                }
                if (child.name == "level")
                {
                    child.GetComponent<Text>().text = "lvl " + level;
                }
            }
        }      

    }
}

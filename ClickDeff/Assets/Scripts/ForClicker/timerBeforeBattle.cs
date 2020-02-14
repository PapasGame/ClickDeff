using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerBeforeBattle : MonoBehaviour

{
    public float seconds;
    public float minutes;

    string stringSeconds;
    string stringMinutes;

    private float x1 = 1.0f, y1 = 1.0f;
    private float x2 = 1.25f, y2 = 1.25f;

    private Vector3 newscale;

    public Text TextTime;

    void Update()
    {       

        do
        {
            seconds -= Time.deltaTime;

            stringSeconds = seconds.ToString();
            stringMinutes = minutes.ToString();

            if (seconds <= 10 && minutes == 0)
            {

                if ((int)seconds % 2 == 0)      //change size of time
                {
                    newscale = new Vector3(x1, y1, 0.0f);
                }
                else newscale = new Vector3(x2, y2, 0.0f);
                transform.localScale = Vector3.Lerp(transform.localScale, newscale, Time.deltaTime + 0.01f);

                TextTime.color = Color.red; //change color of time
            }

            if (seconds < 10)
            {
                TextTime.text = minutes + ":0" + (int)seconds;
            }
            else TextTime.text = minutes + ":" + (int)seconds;

            if (seconds <= 0)
            {
                minutes -= 1.0f;
                seconds = 60.0f;
            }

        } while ((int)seconds != 0 && (int)minutes != 0);
        
    }
}

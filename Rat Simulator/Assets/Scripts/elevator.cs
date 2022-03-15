using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour
{
    public float time = 0;
    private float waitTime = 2f;
    private float pos;
    private bool timeStart = false;
    private float dir;
    private bool toggle = true;
    private float currY;
    // Start is called before the first frame update
    void Start()
    {
        currY = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        pos = this.transform.position.y;
        if ((pos <= 0 + currY || pos >= 6.74 + currY) && toggle)
        {
            timeStart = true;
            toggle = false;
        }
        if (timeStart)
        {
            time += Time.deltaTime;
            if (time >= waitTime)
            {
                timeStart = false;
                time = 0;
            }
        }
        else
        {
            if (pos <= 0 + currY)
                dir = 1f;
            else if (pos >= 6.74 + currY)
                dir = -1f;
            move(dir);
        }
        if (pos >= 2f  + currY && pos <= 4f + currY)
            toggle = true;
    }
    void move(float dir)
    {
        this.transform.Translate(0, dir * Time.deltaTime, 0);
    }
}

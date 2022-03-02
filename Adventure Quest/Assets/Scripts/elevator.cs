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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = this.transform.position.y;
        if ((pos <= 0 || pos >= 6.74) && toggle)
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
            if (pos <= 0)
                dir = 1f;
            else if (pos >= 6.74)
                dir = -1f;
            move(dir);
        }
        if (pos >= 2f && pos <= 4f)
            toggle = true;
    }
    void move(float dir)
    {
        this.transform.Translate(0, dir * Time.deltaTime, 0);
    }
}

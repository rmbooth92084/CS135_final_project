using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currHealth;

    public HealthBar healthBar;
    public bool finish = false;
    public Vector3 startPos;

    private float time = 0f;
    private float maxTime = 1f;
    // Start is called before the first frame update
    void Awake()
    {
        currHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        startPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //these statments make the health degridations slower
        //to make it easier on the player
        if (currHealth < 50)
            maxTime = 1.5f;
        else if (currHealth < 25)
            maxTime = 2f;
        maxTime = 1f;


        time += Time.deltaTime;
        if(time >= maxTime)
        {
            time = 0f;
            damage(1);
        }
        if(currHealth <= 0)
        {
            this.transform.position = startPos;
            currHealth = 100;
        }
        if (finish)
        {
            this.transform.position = startPos;
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 25f, this.transform.position.z);
            currHealth = 100;
            finish = false;
        }

    }
    public void damage(int damage)
    {
        currHealth -= damage;

        healthBar.SetHealth(currHealth);
    }

}

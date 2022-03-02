using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currHealth;

    public HealthBar healthBar;

    private float time = 0f;
    private float maxTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        currHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            damage(20);
        }

    }
    public void damage(int damage)
    {
        currHealth -= damage;

        healthBar.SetHealth(currHealth);
    }

}

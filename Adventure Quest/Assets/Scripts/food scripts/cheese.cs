using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheese : MonoBehaviour
{
    public Player player;
    public bool isGood; //determins if it's good or bad food
    public int intencity; // how strong the food is
    public GameObject food; //a handle on itself
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        food.SetActive(false);//diables the object
        if(isGood)
            player.damage(intencity * -1);
        else
            player.damage(intencity);
    }
}

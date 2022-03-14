using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class percept : MonoBehaviour
{
    public GameObject target;
    public GameObject player;
    public GameObject self;
    public float size;
    public bool enabled = false;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        size = self.transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (!enabled)
            return;

        if (this.transform.localScale.x <= size / 2)
        {
            self.gameObject.SetActive(false);
            target.gameObject.SetActive(false);
            door.gameObject.SetActive(false);
        }
        //Calculates the scale of the red sphere to the player
        float tarDistance = Vector3.Distance(player.transform.position, target.transform.position);
        float scale = target.transform.localScale.x / tarDistance;
        //gets the distance of the player to the blue sphere this script is on
        float distance = Vector3.Distance(player.transform.position, this.transform.position);
        //does the calculation and changes to get the perspective looks the same as the red sphere
        float newScale = scale * distance;
        this.transform.localScale = new Vector3(newScale, newScale, newScale);
    }
}

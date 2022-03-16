using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    public Player player;

    private void OnTriggerEnter(Collider other)
    {
        player.finish = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeHint : MonoBehaviour {
    public GameObject finish;
    public GameObject player;
    private Vector2 finish_position;
    private Vector2 player_position;
    private UnityEngine.UI.Text hint_text;
    private float distance_to_goal;
    
    public bool in_bounds;

    void Start() {
        hint_text = this.GetComponent<UnityEngine.UI.Text>();
        finish_position = new Vector2(finish.transform.position.x, finish.transform.position.z);
        in_bounds = false;
    }

    void Update() {
        if (in_bounds) {
            player_position = new Vector2(player.transform.position.x, player.transform.position.z);
            distance_to_goal = Vector2.Distance(finish_position, player_position);

            if (distance_to_goal < 1.5) {
                hint_text.text = "Finish!";
                hint_text.color = Color.green;
            }
            else if (distance_to_goal < 3) {
                hint_text.text = "Close!!!";
                hint_text.color = Color.green;
            }
            else if (distance_to_goal < 5) {
                hint_text.text = "Getting closer!!";
                hint_text.color = Color.green;
            }
            else if (distance_to_goal < 8) {
                hint_text.text = "Getting closer!";
                hint_text.color = new Color(1.0f, 0.64f, 0.0f);
            }
            else {
                hint_text.text = "Not close";
                hint_text.color = Color.red;
            }
        }
    }
}
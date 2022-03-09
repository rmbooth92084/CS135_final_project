using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeBounds : MonoBehaviour {
    public GameObject player;
    public GameObject maze_script;
    private MazeHint Maze_Hint;
    private Vector3 player_position;

    void Start() {
        Maze_Hint = maze_script.GetComponent<MazeHint>();
    }

    void OnTriggerEnter(Collider other) {
        Maze_Hint.in_bounds = true;
    }
    void OnTriggerExit(Collider other) {
        Maze_Hint.in_bounds = false;
    }

    void Update() {

    }
}

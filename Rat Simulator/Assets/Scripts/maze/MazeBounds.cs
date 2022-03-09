using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeBounds : MonoBehaviour {
    public GameObject maze_script;
    private MazeHint Maze_Hint;

    void Start() {
        Maze_Hint = maze_script.GetComponent<MazeHint>();
    }

    void OnTriggerEnter(Collider other) {
        Maze_Hint.set_bounds(true);
    }
    void OnTriggerExit(Collider other) {
        Maze_Hint.set_bounds(false);
    }

    void Update() {

    }
}
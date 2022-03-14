using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicator : MonoBehaviour {
    private float time_passed;
    private float blink_time;
    private float random_interval;
    private bool poison;

    private Renderer indicator_color;

    public GameObject cheese_normal;
    public GameObject cheese_poison;
    private Vector3 storage_position;
    private GameObject projectile;
    private float distance_traveled;
    private float projectile_timer;

    void Start() {
        poison = false;
        time_passed = 0f;
        blink_time = 0f;
        indicator_color = this.GetComponent<Renderer>();
        poison = true;
        storage_position = this.transform.position;
        projectile_timer = 0;
    }

    void Update() {
        /*
           blink_time += Time.deltaTime;
        while (blink_time >= 11.0) {
            blink();
            blink_time = 0;
        } */
        // shoot();
    }

    public void shoot() {
        if (poison) {
            projectile = Instantiate(cheese_poison, storage_position, Quaternion.identity);
        }
        else {
            projectile = Instantiate(cheese_normal, storage_position, Quaternion.identity);
        }

        while (distance_traveled < 30) {
            projectile_timer += Time.deltaTime;
            if (projectile_timer == 0.01) {
                var cheese_loc = projectile.transform.position;
                projectile.transform.position = new Vector3(cheese_loc.x, cheese_loc.y, cheese_loc.z - (float)0.01);
                distance_traveled += (float)0.01;                    
                projectile_timer = 0;
            }
        }
        Destroy(projectile);
    }

    public void blink() {
        Color light_color;
        random_interval = Random.Range(3.0f, 6.0f);

        if (Random.value >= 0.3) {
            poison = true;
            light_color = Color.red;
        }
        else {
            poison = false;
            light_color = Color.green;
        }
        while (time_passed < random_interval) {
            time_passed += Time.deltaTime;
        }

        // Blinks random color (red = poison, green = normal)
        time_passed = 0f;
        while (time_passed < 1.0f) {
            indicator_color.material.SetColor("_Color", light_color);
            time_passed += Time.deltaTime;
        }
        while (time_passed < 1.5f) {
            time_passed += Time.deltaTime;
        }
        while (time_passed < 2.5f) {
            indicator_color.material.SetColor("_Color", light_color);
            time_passed += Time.deltaTime;
        }
        while (time_passed < 3.0f) {
            time_passed += Time.deltaTime;
        }
        while (time_passed < 4.0f) {
            indicator_color.material.SetColor("_Color", light_color);
            time_passed += Time.deltaTime;
        }
        time_passed = 0f;
    }
}
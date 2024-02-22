using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakeable : MonoBehaviour {
    public GameObject particles;
    public Points points;

    // Executed when is Trigger false
    void OnCollisionEnter(Collision other) {
        if (other.collider.CompareTag("Ball")) {
            Debug.Log("Destroy block!");
            Instantiate(particles, other.transform.position, Quaternion.identity);
            Destroy(gameObject);
            transform.SetParent(null);
            points.IncreasePoints();
        }
    }
}

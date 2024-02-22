using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {
    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            Lifes.lifes = 2;
            Points.points = 0;
            SceneManager.LoadScene(1);
        }
    }
}

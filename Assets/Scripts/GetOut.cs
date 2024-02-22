using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetOut : MonoBehaviour {

    public bool isMenu;

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (isMenu) Application.Quit();
            else SceneManager.LoadScene(0);
        }
    }
}

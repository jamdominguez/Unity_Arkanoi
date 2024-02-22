using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

    public string levelToLoadName;
    public float loadDelay;

    [ContextMenu("Invoke Load")]
    public void InvokeLoad() {
        Invoke("LoadLevel", loadDelay);
    }

    void LoadLevel() {
        if (!IsTheLastLevel()) Lifes.lifes++;
        SceneManager.LoadScene(levelToLoadName);
    }

    public bool IsTheLastLevel() {
        return levelToLoadName == "Menu";
    }
}

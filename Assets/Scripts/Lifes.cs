using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lifes : MonoBehaviour {
    public static int lifes = 2;
    public Text lifesText;
    public PlayerController player;
    public Ball ball;
    public GameObject gameOverObj;
    public NextLevel nextLevel;
    public RunSounds sounds;

    void Start() {
        lifesText.text = "Vidas: " + Lifes.lifes;
    }

    public void DecreaseLifes() {
        if (Lifes.lifes > 0) {
            sounds.PlayFail();
            lifesText.text = "Vidas: " + --Lifes.lifes;
            player.Reset();
            ball.Reset();
        } else {
            sounds.PlayGameOver();
            gameOverObj.SetActive(true); // activate object
            nextLevel.levelToLoadName = "Menu";
            nextLevel.InvokeLoad();
            ball.StopMovement(); // stop ball movement
            player.enabled = false; // unactivate component to skip move the bar
        }
    }
}

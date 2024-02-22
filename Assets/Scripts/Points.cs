using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour {

    public Transform levelBlocks;
    public GameObject levelCompleteObj;
    public GameObject gameCompleteObj;
    public NextLevel nextLevel;
    public Ball ball;
    public PlayerController player;
    public Text pointsText;
    public RunSounds sounds;

    public static int points = 0;

    void Start() {
        pointsText.text = "Puntos: " + Points.points;
    }

    public void IncreasePoints() {
        pointsText.text = "Points: " + ++Points.points;              
        if (levelBlocks.childCount == 0) { // level finalized            
            sounds.PlayCompleted();
            // stop ball and bar
            ball.StopMovement();
            player.enabled = false;
            // check what message must show according next level
            if (nextLevel.IsTheLastLevel()) gameCompleteObj.SetActive(true);
            else levelCompleteObj.SetActive(true);
            // invoke load next level
            nextLevel.InvokeLoad();
        } else if (levelBlocks.childCount < 6) {
            sounds.Faster();
        }
    }
}

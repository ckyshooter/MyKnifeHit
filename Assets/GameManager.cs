using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static bool isGame = true;
    [SerializeField] private GameObject spawnKnifesController;

    public static int score=0;
    public static int highScore;

    public static int ammunition;
    public static int ammunitionStaticHud;
    public static bool resetStage;
    private void Start() {

        spawnKnifesController = GameObject.FindGameObjectWithTag("SpawnKnifes");
        highScore = PlayerPrefs.GetInt("HighScore");
        resetStage = false;
    }

    private void Update() {

        if (score > highScore) {

            PlayerPrefs.SetInt("HighScore", score);
        }

        if (isGame) {

            spawnKnifesController.SetActive(true);
        } else {

            spawnKnifesController.SetActive(false);
        }
    }

}

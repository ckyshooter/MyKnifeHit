using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject[] nivels;
    public static int intNivelController;

    void Start() {

        intNivelController = 0;
    }

    private void Update() {

        switch (intNivelController) {

            case 0:
                nivels[0].SetActive(true);
                nivels[1].SetActive(false);
                nivels[2].SetActive(false);
                break;
            case 1:
                nivels[0].SetActive(false);
                nivels[1].SetActive(true);
                nivels[2].SetActive(true);
                break;
        }
    }

    public void MenuActive() {

        intNivelController = 0;
    }

    public void GameActive() {

        intNivelController = 1;
    }
}

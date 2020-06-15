using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

    public static int stageInt;
    
    void Start() {

        stageInt = 0;
        NextStage();
    }

    // Update is called once per frame
    void Update() {


    }

    public void NextStage() {

        switch (stageInt) {

            case 0:

                GameManager.ammunition = 7;
                GameManager.ammunitionStaticHud = 7;
                break;
            case 1:

                GameManager.ammunition = 9;
                GameManager.ammunitionStaticHud = 9;
                break;
            case 2:

                GameManager.ammunition = 10;
                GameManager.ammunitionStaticHud = 10;
                break;
            case 3:

                GameManager.ammunition = 8;
                GameManager.ammunitionStaticHud = 8;
                break;
        }
    }
}

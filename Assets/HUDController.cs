using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUDController : MonoBehaviour {

    public TMP_Text score;
    public TMP_Text ammunition;
    private void Update() {

        score.text =  GameManager.score.ToString();
        ammunition.text = "Acertou: " + (GameManager.ammunitionStaticHud - GameManager.ammunition) + " / " + GameManager.ammunitionStaticHud;
    }
}

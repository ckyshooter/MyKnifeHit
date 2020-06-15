using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmunitionHUDController : MonoBehaviour {

    public GameObject ammunitionHUD;

    private GameObject[] ammunitionArray;

    // Start is called before the first frame update
    void Start() {
        //StartCoroutine(teste());
        for (int i = 0; i < GameManager.ammunition; i++)
        {

            ammunitionArray[i] = Instantiate(ammunitionHUD, new Vector3(i * 2f, 0, 0), Quaternion.identity);
            ammunitionArray[i].transform.parent = gameObject.transform;
        }
    }

    // Update is called once per frame
    void Update() {

    }

    IEnumerator teste() {

        for (int i = 0; i < GameManager.ammunition; i++) {

            ammunitionArray[i] = Instantiate(ammunitionHUD, new Vector3(i * 2f, 0, 0), Quaternion.identity);
        }
        yield return new WaitForSeconds(1.0f);

        Array.Clear(ammunitionArray, 0, ammunitionArray.Length);
        StartCoroutine(teste());
    }
}

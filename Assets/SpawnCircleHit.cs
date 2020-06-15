using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCircleHit : MonoBehaviour 
{
    public GameObject spawnCircleHit;

    public GameObject circleHit;

    public LevelController levelController;
    public void InstantiateSpawnCircleHit() {

        GameObject circlehit;
        circlehit = Instantiate(spawnCircleHit, transform.position, transform.rotation);
        circlehit.transform.parent = gameObject.transform;
    }

    void Update() {

        if (circleHit == null) {

            InstantiateSpawnCircleHit();
        }

        circleHit = GameObject.FindGameObjectWithTag("CircleHit");

        Debug.Log("Opa: " + GameManager.ammunition);

        if (GameManager.ammunition == 0) {

            Destroy(circleHit);
            LevelController.stageInt++;
            Debug.Log("Opa");

            levelController.NextStage();
        }
    }
}

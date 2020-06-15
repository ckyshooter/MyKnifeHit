using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCircleHit : MonoBehaviour 
{
    public GameObject[] spawnCircleHit;

    public GameObject circleHit;

    public LevelController levelController;
    public void InstantiateSpawnCircleHit() {
        int randomValeu = Random.Range(0, spawnCircleHit.Length);


        GameObject circlehit;
        circlehit = Instantiate(spawnCircleHit[randomValeu], transform.position, transform.rotation);
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

            if (LevelController.stageInt == 3)
                LevelController.stageInt = 0;
            else
                LevelController.stageInt++;

            Debug.Log("Opa");

            levelController.NextStage();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKnifesController : MonoBehaviour {

    public GameObject knife;

    public void InstantiateNewKnife() {

        GameObject knifes; 
        knifes = Instantiate(knife, transform.position, transform.rotation);
        knifes.transform.parent = gameObject.transform;
    }
}

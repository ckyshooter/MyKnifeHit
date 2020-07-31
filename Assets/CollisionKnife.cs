using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionKnife : MonoBehaviour {

    private Rigidbody2D rb2D;
    private BoxCollider2D boxCollider2D;
    private SpawnKnifesController spawnKnifesController;

    void Start()
    {

        rb2D = GetComponent<Rigidbody2D>();

        boxCollider2D = GetComponent<BoxCollider2D>();

        spawnKnifesController = GameObject.FindGameObjectWithTag("SpawnKnifes").GetComponent<SpawnKnifesController>();

    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        transform.parent = other.transform;

        boxCollider2D.isTrigger = true;
        spawnKnifesController.InstantiateNewKnife();
        rb2D.constraints = RigidbodyConstraints2D.FreezeAll;
        GameManager.ammunition--;
        Debug.Log("Oi");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Knifes") {

            GameManager.isGame = false;
            boxCollider2D.enabled = false;
            GameController.intNivelController = 2;
        }
    }
}

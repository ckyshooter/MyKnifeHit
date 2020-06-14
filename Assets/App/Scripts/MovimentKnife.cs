using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentKnife : MonoBehaviour {

    private Rigidbody2D rb2D;
    [SerializeField]private float velocity;

    private SpawnKnifesController spawnKnifesController;

    private BoxCollider2D boxCollider2D;

    void Start() {

        rb2D = GetComponent<Rigidbody2D>();

        boxCollider2D = GetComponent<BoxCollider2D>();

        spawnKnifesController = GameObject.FindGameObjectWithTag("SpawnKnifes").GetComponent<SpawnKnifesController>();

        if (velocity == 0) {

            velocity = 0.5f;
        }
    }

    void Update() {

        Debug.Log("1");

        if (!GameManager.isGame)
            return;

        Debug.Log("2");

        if (Input.GetKeyDown(KeyCode.E)) {

            Debug.Log("3");
            rb2D.AddForce(transform.up * velocity, ForceMode2D.Force);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {

        if (other.gameObject.tag == "Knife") {
            GameManager.isGame = false;
            boxCollider2D.enabled = false;
        } else {

            if (!GameManager.isGame)
                return;

            transform.parent = other.transform;

            //boxCollider2D.enabled = false;
            spawnKnifesController.InstantiateNewKnife();
            rb2D.constraints = RigidbodyConstraints2D.FreezeAll;
            Debug.Log("Oi");
        }


    }
}

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

        if (!GameManager.isGame)
            return;

        if ((Input.GetKeyDown(KeyCode.E) || Input.GetMouseButtonDown(0)) && GameManager.ammunition > 0) {

            rb2D.AddForce(transform.up * velocity, ForceMode2D.Force);

            if(!boxCollider2D.isTrigger)
                GameManager.score++;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundKnifeController : MonoBehaviour {

    private AudioSource source;

    //[SerializeField] public AudioClip[] shotAudioClip;
    [SerializeField] private AudioClip[] arrowCollisionOnWood;
    [SerializeField] private AudioClip[] arrowCollisionOnTheOtherArrow;

    private AudioClip clip;

    [SerializeField] [Range(0.0F, 1.0F)] private float FloatValueVolume;
    [SerializeField] [Range(0.0F, 1.0F)] private float FloatValuePitch;

    [SerializeField]private int maxValueVolume;
    [SerializeField]private int maxValuePitch;
    void Start() {

        source = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D other) {

        if (other.gameObject.tag == "CircleHit") {
            clip = arrowCollisionOnWood[Random.Range(0, arrowCollisionOnWood.Length)];
        }

        StartCoroutine(StartTheAudio());
    }

    private void OnTriggerEnter2D(Collider2D other) {

        if (other.gameObject.tag == "Knifes") {
            clip = arrowCollisionOnTheOtherArrow[Random.Range(0, arrowCollisionOnTheOtherArrow.Length)];
        }

        StartCoroutine(StartTheAudio());
    }

    IEnumerator StartTheAudio() {

        source.clip = clip;
        source.volume = Random.Range(FloatValueVolume, maxValueVolume);
        source.pitch = Random.Range(FloatValuePitch, maxValuePitch);
        source.Play();
        yield return null;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class RotationControllerCircleHit : MonoBehaviour {

    public GameObject MyObjectRotate;
    // Start is called before the first frame update
    void Start() {

        MyObjectRotate = gameObject;

        MyObjectRotate.transform.DORotate(new Vector3(0, 0, 360),3f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

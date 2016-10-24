﻿using UnityEngine;
using System.Collections;

public class camShakeSimple : MonoBehaviour {

    Vector3 originalCameraPosition;

    float shakeAmt = 0;

    public Camera mainCamera;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Respawn") {
            shakeAmt = other.relativeVelocity.magnitude * .0025f;
            StartShaksing();
        }
    }

    void CameraShake()
    {
        if (shakeAmt > 0)
        {
            float quakeAmt = Random.Range(1,5) * shakeAmt * 2 - shakeAmt;
            Vector3 pp = mainCamera.transform.position;
            pp.y += quakeAmt; // can also add to x and/or z
            mainCamera.transform.position = pp;
        }
    }

    public void StartShaksing() {
        InvokeRepeating("CameraShake", 0, .01f);
        Invoke("StopShaking", 0.7f);
    }

    void StopShaking()
    {
        CancelInvoke("CameraShake");
        mainCamera.transform.position = new Vector3 (GameObject.Find("Player").transform.position.x, GameObject.Find("Player").transform.position.y, GameObject.Find("Player").transform.position.z);
    }

}
﻿using UnityEngine;
using System.Collections;

public class UserInputs : MonoBehaviour {
    float timeAngle;
    // Use this for initialization
    void Start () {
        timeAngle = Time.deltaTime * 15;
    }

    private float getAngle(float angle)
    {
        return (angle > 180) ? angle - 360 : angle;
    }
	
	// Update is called once per frame
	void Update () {
        // Moving the board
        float xRotation = getAngle(transform.eulerAngles.x);
        float zRotation = getAngle(transform.eulerAngles.z);
        
        if ((Input.GetAxis("Vertical") <= 0.2) && xRotation <= 10)
        {
            transform.Rotate(Vector3.right, timeAngle);
        }
        if ((Input.GetAxis("Vertical")  >= -0.2) && xRotation >= -10)
        {
            transform.Rotate(Vector3.left, timeAngle);
        }
        if (Input.GetAxis("Horizontal") <= 0.2 && zRotation <= 10)
        {
            transform.Rotate(Vector3.forward, timeAngle);
        }
        if (Input.GetAxis("Horizontal") >= -0.2 && zRotation >= -10)
        {
            transform.Rotate(Vector3.back, timeAngle);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
	}
}

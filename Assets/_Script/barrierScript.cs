using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrierScript : MonoBehaviour {
    private float yRotation;
    private bool rotateClock = false;
    private bool rotateCounter = false;

	// Use this for initialization
	void Start () {
        yRotation = transform.localEulerAngles.y;
    }

    // Update is called once per frame
    void Update () {
        if (rotateClock)
        {
            Rotating(true);
        } else if (rotateCounter) {
            Rotating(false);
        }
        else
        {
            // when The rotation is finished, I will use the formula to correct the barriers to the exact right angle rotation
            float yRot = Mathf.Round(transform.localEulerAngles.y / 90) * 90;
            transform.localRotation = Quaternion.Euler(transform.localEulerAngles.x, yRot, transform.localEulerAngles.z);
            yRotation = transform.localEulerAngles.y;

            int num = Random.Range(0, 10000);
            if (num == 99) {
                rotateClock = true;
                rotateCounter = false;
            }
            if (num == 999) {
                rotateClock = false;
                rotateCounter = true;
            }
        }
    }

    private void Rotating(bool clockwise)
    {
        // Random rotation of 90 degrees
        float y = transform.localEulerAngles.y;
        if (Mathf.Abs(Mathf.DeltaAngle(y, yRotation)) >= 90)
        {
            rotateClock = false;
            rotateCounter = false;
            
        }
        if (clockwise)
        {
            transform.Rotate(Vector3.forward, Time.deltaTime * 100);
        } else
        {
            transform.Rotate(Vector3.back, Time.deltaTime * 100);
        }       
    }
}

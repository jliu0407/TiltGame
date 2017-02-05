using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinScript : MonoBehaviour {
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up, Time.deltaTime * 100);
        float count = Mathf.PingPong(Time.time, 0.6f) + 0.4f;
        gameObject.GetComponent<Light>().range = count;
    }
}

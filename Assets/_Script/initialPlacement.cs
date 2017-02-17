using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initialPlacement : MonoBehaviour {
    private Vector3[] hingePos = {
        new Vector3(-4.0f, 0.3f, -4.0f), new Vector3(-2.0f, 0.2f, -4.0f), new Vector3(0.0f, 0.2f, -4.0f), new Vector3(2.0f, 0.2f, -4.0f), new Vector3(4.0f, 0.2f, -4.0f),
        new Vector3(3.0f, 0.2f, -3.0f), new Vector3(1.0f, 0.2f, -3.0f), new Vector3(-1.0f, 0.2f, -3.0f), new Vector3(-3.0f, 0.2f, -3.0f),
        new Vector3(-4.0f, 0.2f, -2.0f), new Vector3(-2.0f, 0.2f, -2.0f), new Vector3(0.0f, 0.2f, -2.0f), new Vector3(2.0f, 0.2f, -2.0f), new Vector3(4.0f, 0.2f, -2.0f),
        new Vector3(3.0f, 0.2f, -1.0f), new Vector3(1.0f, 0.2f, -1.0f), new Vector3(-1.0f, 0.2f, -1.0f), new Vector3(-3.0f, 0.2f, -1.0f),
        new Vector3(-4.0f, 0.2f, 0.0f), new Vector3(-2.0f, 0.2f, 0.0f), new Vector3(2.0f, 0.2f, 0.0f), new Vector3(4.0f, 0.2f, 0.0f),
        new Vector3(3.0f, 0.2f, 1.0f), new Vector3(1.0f, 0.2f, 1.0f), new Vector3(-1.0f, 0.2f, 1.0f), new Vector3(-3.0f, 0.2f, 1.0f),
        new Vector3(-4.0f, 0.2f, 2.0f), new Vector3(-2.0f, 0.2f, 2.0f), new Vector3(0.0f, 0.2f, 2.0f), new Vector3(2.0f, 0.2f, 2.0f), new Vector3(4.0f, 0.2f, 2.0f),
        new Vector3(3.0f, 0.2f, 3.0f), new Vector3(1.0f, 0.2f, 3.0f), new Vector3(-1.0f, 0.2f, 3.0f), new Vector3(-3.0f, 0.2f, 3.0f),
        new Vector3(-4.0f, 0.2f, 4.0f), new Vector3(-2.0f, 0.2f, 4.0f), new Vector3(0.0f, 0.2f, 4.0f), new Vector3(2.0f, 0.2f, 4.0f), new Vector3(4.0f, 0.2f, 4.0f)
    };
    private GameObject star;
    private GameObject barrier;
    // Use this for initialization
    void Start () {
        GameObject starParent = GameObject.Find("Stars");
        GameObject barrierParent = GameObject.Find("Obstacles");
        for (int i = 0; i < hingePos.Length; i++)
        {
            Quaternion rotation = generateRotation();
            barrier = Instantiate(Resources.Load("Prefabs/barrier"), hingePos[i], rotation) as GameObject;
            barrier.transform.parent = barrierParent.transform;
        }
        ArrayList starPos = new ArrayList();
        Vector3 pos = new Vector3(4.5f, 0.6f, 4.5f);
        starPos.Add(pos);
        for (int i = 0; i < 6; i++)
        {
            do
            {
                pos = new Vector3(Random.Range(-5, 4)+0.5f, 0.6f, Random.Range(-5, 4)+0.5f);
            } while (starPos.Contains(pos));
            starPos.Add(pos);
            star = Instantiate(Resources.Load("Prefabs/Collectable"), pos, new Quaternion(0, 0, 0, 0)) as GameObject;
            star.transform.parent = starParent.transform;
        }

        Physics.IgnoreLayerCollision(star.layer, barrier.layer, true);
    }

    // Update is called once per frame
    void Update () {
		
	}

    private Quaternion generateRotation()
    {
        int num = Random.Range(0, 4);
        switch (num)
        {
            case 1:
                return Quaternion.Euler(-90, 90, 0);
            case 2:
                return Quaternion.Euler(-90, -90, 0);
            case 3:
                return Quaternion.Euler(-90, 180, 0);
        }
        return Quaternion.Euler(-90, 0, 0);
    }
}

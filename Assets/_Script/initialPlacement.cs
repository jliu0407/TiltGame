using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initialPlacement : MonoBehaviour {

    private GameObject star;
    private GameObject barrier;
    // Use this for initialization
    void Start () {
        GameObject starParent = GameObject.Find("Stars");
        GameObject barrierParent = GameObject.Find("Obstacles");
        for (int i = -4; i < 5; i++)
        {
            for (int j = -4; j < 5; j++)
            {
                if (!(i == 0 && j == 0)) {
                    Vector3 position = new Vector3(i, 0.2f, j);
                    if ((i % 2 == 0 && j % 2 == 0) || (i % 2 != 0 && j % 2 != 0))
                    {
                        Quaternion rotation = generateRotation();
                        barrier = Instantiate(Resources.Load("Prefabs/barrier"), position, rotation) as GameObject;
                        barrier.transform.parent = barrierParent.transform;
                    }
                }
            }
        }

        ArrayList starPos = new ArrayList();
        Vector3 pos = new Vector3(4.5f, 0.6f, 4.5f);
        starPos.Add(pos);
        for (int i = 0; i < 6; i++)
        {
            do
            {
                pos = new Vector3(Random.Range(-5, 5)+0.5f, 0.6f, Random.Range(-5, 5)+0.5f);
            } while (starPos.Contains(pos));
            starPos.Add(pos);
            star = Instantiate(Resources.Load("Prefabs/Collectable"), pos, Quaternion.identity) as GameObject;
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

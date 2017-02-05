using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerScript : MonoBehaviour {
    private bool collide = false;
    private int count;
    public Text countText;
    void Start ()
    {
        count = 0;
        setText(count);
    }
	
	// Update is called once per frame
	void Update () {
        if (collide)
        {
            transform.position += Vector3.up / 4;
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("end"))
        {
            countText.text = "Game Complete with " + count + " stars.";
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
            collide = true;
        }
        if (collision.gameObject.CompareTag("star"))
        {
            count++;
            setText(count);
            collision.gameObject.SetActive(false);
        }

    }

    private void setText(int num)
    {
        countText.text = "Star Collected: " + num;

    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerScript : MonoBehaviour {
    private bool collide = false;
    private int count;

    public Text countText;
    public Text winText;

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
        if (Input.GetButtonDown("Jump"))
        {
            gameObject.GetComponent<Rigidbody>().velocity += Vector3.up * 7; 
        }
        if (transform.position.y < -5)
        {
            countText.text = "";
            winText.text = "Sorry. You lose! Please Press 'R' to restart";
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("end"))
        {
            if (count >= 2)
            {
                countText.text = "";
                winText.text = "Congratulations! You Win!";
                gameObject.GetComponent<Rigidbody>().isKinematic = true;
                collide = true;
            }
            
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
        int remain = 2 - num;
        if (remain > 0)
        {
            countText.text = "Pick-ups Stars remaining: " + remain;
        } else
        {
            countText.text = "Collected Enough Stars, Go to the Goal!";
        }
        

    }
}

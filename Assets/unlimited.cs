using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class unlimited : MonoBehaviour {

    public float forwardForce = -2000f;
    public Rigidbody rb;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
		
	}
}

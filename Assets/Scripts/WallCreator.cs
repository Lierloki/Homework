using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCreator : MonoBehaviour {

    public GameObject wall1;
    public float harder = 0.001f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        for (float b = -6.5f; b < 6.6; b= b+2)
        {
            if (Random.value < harder)
            {
                Instantiate(wall1.transform, new Vector3(b, 1, 80), Quaternion.identity);
                harder = harder + 0.0001f;
            }
        }
    }
}

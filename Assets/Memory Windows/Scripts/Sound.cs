using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {
    public GameObject A;
    public GameObject B;
	// Use this for initialization
	void Start () {
       
    }
    void Update()
    {

        if (GameObject.Find("Manage").GetComponent<Manage>().Sound == 0)
        {
            A.SetActive(true);
            B.SetActive(false);
        }
        if (GameObject.Find("Manage").GetComponent<Manage>().Sound == 1)
        {
            A.SetActive(false);
            B.SetActive(true);
        }
    }
        // Update is called once per frame
        void OnMouseDown()
    {
        if (GameObject.Find("Manage").GetComponent<Manage>().Sound == 0)
        {
            GetComponent<AudioSource>().Play();
        }
        GameObject.Find("Manage").GetComponent<Manage>().Sound += 1;

    }
}
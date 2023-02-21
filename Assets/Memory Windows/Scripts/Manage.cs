using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manage : MonoBehaviour
{
    public GameObject ET;
    public int Sound;
    public bool Lose;

    public bool Stay0;
    public bool Stay1;
    public bool Stay2;
    public bool Stay3;
    public bool Stay4;
    public bool Stay5;
    public bool Stay6;
    public bool Stay7;
    public bool Stay8;
    public bool Stay9;
    public bool Stay10;


    public bool W0;
    public bool W1;
    public bool W2;
    public bool W3;
    public bool W4;
    public bool W5;
    public bool W6;
    public bool W7;
    public bool W8;
    public bool W9;
    public bool W10;

    public int B0;
    public int B1;
    public int B2;
    public int B3;
    public int B4;
    public int B5;
    public int B6;
    public int B7;
    public int B8;
    public int B9;
    public int B10;

    public int Windows;

    public bool Stay;
    public int END;

    public int once;


    // Update is called once per frame
    void Update()
    {
        if (Lose == true)
        {
            once += 1;
            if (once == 1)
            {
                Instantiate(ET, new Vector3(0, 0, -7f), Quaternion.identity);
                StartCoroutine(BB());
            }
        }

        if (Sound >= 2)
        {
            Sound = 0;
        }

        PlayerPrefs.SetInt("Sound", Sound);
        if (END >= 20)
        {
            once += 1;
            if (once == 1)
            {
                GameObject.Find("Particle").GetComponent<ParticleSystem>().Play();
                if (GameObject.Find("Manage").GetComponent<Manage>().Sound == 0)
                {
                    GameObject.Find("Happy").GetComponent<AudioSource>().Play();
                }

                StartCoroutine(AA());
            }
        }


        if (B0 == 1)
        {
            Stay0 = true;
            Stay1 = false;
            Stay2 = false;
            Stay3 = false;
            Stay4 = false;
            Stay5 = false;
            Stay6 = false;
            Stay7 = false;
            Stay8 = false;
            Stay9 = false;
            Stay10 = false;
        }

        if (B1 == 1)
        {
            Stay1 = true;
            Stay0 = false;
            Stay2 = false;
            Stay3 = false;
            Stay4 = false;
            Stay5 = false;
            Stay6 = false;
            Stay7 = false;
            Stay8 = false;
            Stay9 = false;
            Stay10 = false;
        }

        if (B2 == 1)
        {
            Stay2 = true;
            Stay1 = false;
            Stay0 = false;
            Stay3 = false;
            Stay4 = false;
            Stay5 = false;
            Stay6 = false;
            Stay7 = false;
            Stay8 = false;
            Stay9 = false;
            Stay10 = false;
        }

        if (B3 == 1)
        {
            Stay3 = true;
            Stay1 = false;
            Stay2 = false;
            Stay0 = false;
            Stay4 = false;
            Stay5 = false;
            Stay6 = false;
            Stay7 = false;
            Stay8 = false;
            Stay9 = false;
            Stay10 = false;
        }

        if (B4 == 1)
        {
            Stay4 = true;
            Stay1 = false;
            Stay2 = false;
            Stay3 = false;
            Stay0 = false;
            Stay5 = false;
            Stay6 = false;
            Stay7 = false;
            Stay8 = false;
            Stay9 = false;
            Stay10 = false;
        }

        if (B5 == 1)
        {
            Stay5 = true;
            Stay1 = false;
            Stay2 = false;
            Stay3 = false;
            Stay4 = false;
            Stay0 = false;
            Stay6 = false;
            Stay7 = false;
            Stay8 = false;
            Stay9 = false;
            Stay10 = false;
        }

        if (B6 == 1)
        {
            Stay6 = true;
            Stay1 = false;
            Stay2 = false;
            Stay3 = false;
            Stay4 = false;
            Stay5 = false;
            Stay0 = false;
            Stay7 = false;
            Stay8 = false;
            Stay9 = false;
            Stay10 = false;
        }

        if (B7 == 1)
        {
            Stay7 = true;
            Stay1 = false;
            Stay2 = false;
            Stay3 = false;
            Stay4 = false;
            Stay5 = false;
            Stay6 = false;
            Stay0 = false;
            Stay8 = false;
            Stay9 = false;
            Stay10 = false;
        }

        if (B8 == 1)
        {
            Stay8 = true;
            Stay1 = false;
            Stay2 = false;
            Stay3 = false;
            Stay4 = false;
            Stay5 = false;
            Stay6 = false;
            Stay7 = false;
            Stay0 = false;
            Stay9 = false;
            Stay10 = false;
        }

        if (B9 == 1)
        {
            Stay9 = true;
            Stay1 = false;
            Stay2 = false;
            Stay3 = false;
            Stay4 = false;
            Stay5 = false;
            Stay6 = false;
            Stay7 = false;
            Stay8 = false;
            Stay0 = false;
            Stay10 = false;
        }

        if (B10 == 1)
        {
            Stay10 = true;
            Stay1 = false;
            Stay2 = false;
            Stay3 = false;
            Stay4 = false;
            Stay5 = false;
            Stay6 = false;
            Stay7 = false;
            Stay8 = false;
            Stay9 = false;
            Stay0 = false;
        }


        //---------------------------
        if (B0 == 2)
        {
            W0 = true;
        }

        if (B1 == 2)
        {
            W1 = true;
        }

        if (B2 == 2)
        {
            W2 = true;
        }

        if (B3 == 2)
        {
            W3 = true;
        }

        if (B4 == 2)
        {
            W4 = true;
        }

        if (B5 == 2)
        {
            W5 = true;
        }

        if (B6 == 2)
        {
            W6 = true;
        }

        if (B7 == 2)
        {
            W7 = true;
        }

        if (B8 == 2)
        {
            W8 = true;
        }

        if (B9 == 2)
        {
            W9 = true;
        }

        if (B10 == 2)
        {
            W10 = true;
        }
    }

    // Use this for initialization
    void Start()
    {
        Sound = PlayerPrefs.GetInt("Sound", Sound);
        if (GameObject.Find("Particle") != null)
        {
            GameObject.Find("Particle").GetComponent<ParticleSystem>().Stop();
        }

        Stay = false;
    }

    IEnumerator BB()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    IEnumerator AA()
    {
        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
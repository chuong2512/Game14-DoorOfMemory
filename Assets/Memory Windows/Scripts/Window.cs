using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    public GameObject Window2;

    public int Anim;

    public bool Once;

    //  public bool Click;
    public bool Check;
    // Use this for initialization

    public int lose;
    public int A0;
    public int A1;
    public int A2;
    public int A3;
    public int A4;
    public int A5;

    public int A6;
    public int A7;
    public int A8;
    public int A9;
    public int A10;

    void Start()
    {
        Anim = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (A0 == 1 && GameObject.Find("Manage").GetComponent<Manage>().W0 == true)
        {
            GameObject.Find("Manage").GetComponent<Manage>().END += 1;
            Instantiate(Window2, new Vector3(transform.position.x, transform.position.y, transform.position.z),
                Quaternion.identity);
            if (GameObject.Find("Manage").GetComponent<Manage>().Sound == 0)
            {
                GameObject.Find("Clicksound2").GetComponent<AudioSource>().Play();
            }

            Destroy(gameObject);
        }

        if (A1 == 1 && GameObject.Find("Manage").GetComponent<Manage>().W1 == true)
        {
            GameObject.Find("Manage").GetComponent<Manage>().END += 1;
            Instantiate(Window2, new Vector3(transform.position.x, transform.position.y, transform.position.z),
                Quaternion.identity);
            if (GameObject.Find("Manage").GetComponent<Manage>().Sound == 0)
            {
                GameObject.Find("Clicksound2").GetComponent<AudioSource>().Play();
            }

            Destroy(gameObject);
        }

        if (A2 == 1 && GameObject.Find("Manage").GetComponent<Manage>().W2 == true)
        {
            GameObject.Find("Manage").GetComponent<Manage>().END += 1;
            Instantiate(Window2, new Vector3(transform.position.x, transform.position.y, transform.position.z),
                Quaternion.identity);
            if (GameObject.Find("Manage").GetComponent<Manage>().Sound == 0)
            {
                GameObject.Find("Clicksound2").GetComponent<AudioSource>().Play();
            }

            Destroy(gameObject);
        }

        if (A3 == 1 && GameObject.Find("Manage").GetComponent<Manage>().W3 == true)
        {
            GameObject.Find("Manage").GetComponent<Manage>().END += 1;
            Instantiate(Window2, new Vector3(transform.position.x, transform.position.y, transform.position.z),
                Quaternion.identity);
            if (GameObject.Find("Manage").GetComponent<Manage>().Sound == 0)
            {
                GameObject.Find("Clicksound2").GetComponent<AudioSource>().Play();
            }

            Destroy(gameObject);
        }

        if (A4 == 1 && GameObject.Find("Manage").GetComponent<Manage>().W4 == true)
        {
            GameObject.Find("Manage").GetComponent<Manage>().END += 1;
            Instantiate(Window2, new Vector3(transform.position.x, transform.position.y, transform.position.z),
                Quaternion.identity);
            if (GameObject.Find("Manage").GetComponent<Manage>().Sound == 0)
            {
                GameObject.Find("Clicksound2").GetComponent<AudioSource>().Play();
            }

            Destroy(gameObject);
        }

        if (A5 == 1 && GameObject.Find("Manage").GetComponent<Manage>().W5 == true)
        {
            GameObject.Find("Manage").GetComponent<Manage>().END += 1;
            Instantiate(Window2, new Vector3(transform.position.x, transform.position.y, transform.position.z),
                Quaternion.identity);
            if (GameObject.Find("Manage").GetComponent<Manage>().Sound == 0)
            {
                GameObject.Find("Clicksound2").GetComponent<AudioSource>().Play();
            }

            Destroy(gameObject);
        }

        if (A6 == 1 && GameObject.Find("Manage").GetComponent<Manage>().W6 == true)
        {
            GameObject.Find("Manage").GetComponent<Manage>().END += 1;
            Instantiate(Window2, new Vector3(transform.position.x, transform.position.y, transform.position.z),
                Quaternion.identity);
            if (GameObject.Find("Manage").GetComponent<Manage>().Sound == 0)
            {
                GameObject.Find("Clicksound2").GetComponent<AudioSource>().Play();
            }

            Destroy(gameObject);
        }

        if (A7 == 1 && GameObject.Find("Manage").GetComponent<Manage>().W7 == true)
        {
            GameObject.Find("Manage").GetComponent<Manage>().END += 1;
            Instantiate(Window2, new Vector3(transform.position.x, transform.position.y, transform.position.z),
                Quaternion.identity);
            if (GameObject.Find("Manage").GetComponent<Manage>().Sound == 0)
            {
                GameObject.Find("Clicksound2").GetComponent<AudioSource>().Play();
            }

            Destroy(gameObject);
        }

        if (A8 == 1 && GameObject.Find("Manage").GetComponent<Manage>().W8 == true)
        {
            GameObject.Find("Manage").GetComponent<Manage>().END += 1;
            Instantiate(Window2, new Vector3(transform.position.x, transform.position.y, transform.position.z),
                Quaternion.identity);
            if (GameObject.Find("Manage").GetComponent<Manage>().Sound == 0)
            {
                GameObject.Find("Clicksound2").GetComponent<AudioSource>().Play();
            }

            Destroy(gameObject);
        }

        if (A9 == 1 && GameObject.Find("Manage").GetComponent<Manage>().W9 == true)
        {
            GameObject.Find("Manage").GetComponent<Manage>().END += 1;
            Instantiate(Window2, new Vector3(transform.position.x, transform.position.y, transform.position.z),
                Quaternion.identity);
            if (GameObject.Find("Manage").GetComponent<Manage>().Sound == 0)
            {
                GameObject.Find("Clicksound2").GetComponent<AudioSource>().Play();
            }

            Destroy(gameObject);
        }

        if (A10 == 1 && GameObject.Find("Manage").GetComponent<Manage>().W10 == true)
        {
            GameObject.Find("Manage").GetComponent<Manage>().END += 1;
            Instantiate(Window2, new Vector3(transform.position.x, transform.position.y, transform.position.z),
                Quaternion.identity);
            if (GameObject.Find("Manage").GetComponent<Manage>().Sound == 0)
            {
                GameObject.Find("Clicksound2").GetComponent<AudioSource>().Play();
            }

            Destroy(gameObject);
        }

        //-----------------------------------------------------

        if (Check == true)
        {
            GetComponent<Animator>().SetInteger("Window", Anim);
        }

        if (Check == false)
        {
            if (Anim == 1)
            {
                Anim = 2;
            }

            GetComponent<Animator>().SetInteger("Window", Anim);
        }

        if (A0 == 1 && GameObject.Find("Manage").GetComponent<Manage>().B0 == 0)
        {
            Check = false;
        }

        if (A1 == 1 && GameObject.Find("Manage").GetComponent<Manage>().B1 == 0)
        {
            Check = false;
        }

        if (A2 == 1 && GameObject.Find("Manage").GetComponent<Manage>().B2 == 0)
        {
            Check = false;
        }

        if (A3 == 1 && GameObject.Find("Manage").GetComponent<Manage>().B3 == 0)
        {
            Check = false;
        }

        if (A4 == 1 && GameObject.Find("Manage").GetComponent<Manage>().B4 == 0)
        {
            Check = false;
        }

        if (A5 == 1 && GameObject.Find("Manage").GetComponent<Manage>().B5 == 0)
        {
            Check = false;
        }

        if (A6 == 1 && GameObject.Find("Manage").GetComponent<Manage>().B6 == 0)
        {
            Check = false;
        }

        if (A7 == 1 && GameObject.Find("Manage").GetComponent<Manage>().B7 == 0)
        {
            Check = false;
        }

        if (A8 == 1 && GameObject.Find("Manage").GetComponent<Manage>().B8 == 0)
        {
            Check = false;
        }

        if (A9 == 1 && GameObject.Find("Manage").GetComponent<Manage>().B9 == 0)
        {
            Check = false;
        }

        if (A10 == 1 && GameObject.Find("Manage").GetComponent<Manage>().B10 == 0)
        {
            Check = false;
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "A0")
        {
            A0 = 1;
        }

        if (coll.gameObject.tag == "A1")
        {
            A1 = 1;
        }

        if (coll.gameObject.tag == "A2")
        {
            A2 = 1;
        }

        if (coll.gameObject.tag == "A3")
        {
            A3 = 1;
        }

        if (coll.gameObject.tag == "A4")
        {
            A4 = 1;
        }

        if (coll.gameObject.tag == "A5")
        {
            A5 = 1;
        }

        if (coll.gameObject.tag == "A6")
        {
            A6 = 1;
        }

        if (coll.gameObject.tag == "A7")
        {
            A7 = 1;
        }

        if (coll.gameObject.tag == "A8")
        {
            A8 = 1;
        }

        if (coll.gameObject.tag == "A9")
        {
            A9 = 1;
        }

        if (coll.gameObject.tag == "A10")
        {
            A10 = 1;
        }
    }


    void OnMouseDown()
    {
        if (Check == false)
        {
            if (GameObject.Find("Manage").GetComponent<Manage>().Sound == 0)
            {
                GameObject.Find("Clicksound").GetComponent<AudioSource>().Play();
            }

            if (A0 == 1)
            {
                Anim = 1;
                GameObject.Find("Manage").GetComponent<Manage>().B1 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B2 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B3 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B4 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B5 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B6 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B7 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B8 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B9 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B10 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B0 += 1;
                Check = true;
            }

            if (A1 == 1)
            {
                Anim = 1;
                GameObject.Find("Manage").GetComponent<Manage>().B0 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B2 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B3 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B4 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B5 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B6 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B7 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B8 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B9 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B10 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B1 += 1;
                Check = true;
            }

            if (A2 == 1)
            {
                Anim = 1;
                GameObject.Find("Manage").GetComponent<Manage>().B1 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B0 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B3 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B4 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B5 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B6 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B7 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B8 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B9 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B10 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B2 += 1;
                Check = true;
            }

            if (A3 == 1)
            {
                Anim = 1;
                GameObject.Find("Manage").GetComponent<Manage>().B1 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B2 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B0 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B4 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B5 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B6 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B7 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B8 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B9 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B10 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B3 += 1;
                Check = true;
            }

            if (A4 == 1)
            {
                Anim = 1;
                GameObject.Find("Manage").GetComponent<Manage>().B1 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B2 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B3 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B0 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B5 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B6 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B7 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B8 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B9 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B10 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B4 += 1;
                Check = true;
            }

            if (A5 == 1)
            {
                Anim = 1;
                GameObject.Find("Manage").GetComponent<Manage>().B1 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B2 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B3 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B4 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B0 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B6 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B7 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B8 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B9 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B10 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B5 += 1;
                Check = true;
            }

            if (A6 == 1)
            {
                Anim = 1;
                GameObject.Find("Manage").GetComponent<Manage>().B1 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B2 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B3 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B4 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B5 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B0 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B7 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B8 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B9 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B10 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B6 += 1;
                Check = true;
            }

            if (A7 == 1)
            {
                Anim = 1;
                GameObject.Find("Manage").GetComponent<Manage>().B1 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B2 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B3 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B4 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B5 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B6 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B0 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B8 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B9 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B10 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B7 += 1;
                Check = true;
            }

            if (A8 == 1)
            {
                Anim = 1;
                GameObject.Find("Manage").GetComponent<Manage>().B1 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B2 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B3 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B4 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B5 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B6 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B7 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B0 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B9 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B10 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B8 += 1;
                Check = true;
            }

            if (A9 == 1)
            {
                Anim = 1;
                GameObject.Find("Manage").GetComponent<Manage>().B1 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B2 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B3 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B4 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B5 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B6 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B7 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B8 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B0 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B10 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B9 += 1;
                Check = true;
            }

            if (A10 == 1)
            {
                Anim = 1;
                GameObject.Find("Manage").GetComponent<Manage>().B1 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B2 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B3 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B4 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B5 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B6 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B7 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B8 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B9 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B0 = 0;
                GameObject.Find("Manage").GetComponent<Manage>().B10 += 1;
                Check = true;
            }
        }
    }

    public void Show()
    {
        GameObject.Find("Manage").GetComponent<Manage>().END += 1;
        Instantiate(Window2, new Vector3(transform.position.x, transform.position.y, transform.position.z),
            Quaternion.identity);

        Destroy(gameObject);
    }

    public bool CheckWindow(Window b)
    {
        if (A0 != b.A0)
        {
            return false;
        }

        if (A1 != b.A1)
        {
            return false;
        }

        if (A2 != b.A2)
        {
            return false;
        }

        if (A3 != b.A3)
        {
            return false;
        }

        if (A4 != b.A4)
        {
            return false;
        }

        if (A5 != b.A5)
        {
            return false;
        }

        if (A6 != b.A6)
        {
            return false;
        }

        if (A7 != b.A7)
        {
            return false;
        }

        if (A8 != b.A8)
        {
            return false;
        }

        if (A9 != b.A9)
        {
            return false;
        }

        if (A10 != b.A10)
        {
            return false;
        }

        return true;
    }
}
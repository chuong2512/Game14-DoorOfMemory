using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    public GameObject A0;
    public GameObject A1;
    public GameObject A2;
    public GameObject A3;
    public GameObject A4;
    public GameObject A5;
    public GameObject A6;
    public GameObject A7;
    public GameObject A8;
    public GameObject A9;
    public GameObject A10;

    public GameObject[] A;
    public GameObject[] Temp;


    public int R;
    public int Once;
    public int X;
    public int Startrandom;
    public List<int> PosList;
    public List<Transform> TransList;
    public List<GameObject> templist;

 

    // Use this for initialization
    void Start()
    {
        PosList= new List<int>() { 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19 };
        templist = new List<GameObject>(){ A0,A1, A2, A3, A4, A5, A6, A7, A8, A9, A10 };
        Temp = new GameObject[10];
        for (int i = 0; i < 10; i++)
        {
            R = Random.Range(0, templist.Count);
           
            Temp[i] = templist[R];
            templist.RemoveAt(R);
        }
        for (int i = 0; i < 10; i++)
        {
            var k = 0;

            for (var j = 0; j < 2; j++) {
                 k = Random.Range(0, TransList.Count);
              
                Instantiate(Temp[i], new Vector3(TransList[k].transform.position.x, TransList[k].transform.position.y, TransList[k].transform.position.z), Quaternion.identity);
                TransList.RemoveAt(k);
            }
                    
        }


        // print(templist);
    }

    // Update is called once per frame
    void Update()
    {

       

        


         

        }
    }



               




    
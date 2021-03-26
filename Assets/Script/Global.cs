using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    bool step_1;
   // public GameObject mat_1;
    float timer;
    int p1;
    int p2;
    int p3;

    public static bool Bomb;
    // Start is called before the first frame update
    void Start()
    {
        
        Bomb = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        p1 = Point_1.p1;
        p2 = Point_2.p2;
        p3 = Point_3.p3;

        if (p1==1 && p2==2 )
           
        {
            Bomb = true;
        }

        if (p1 == 2 && p2 == 1)

        {
            Bomb = true;
        }


        if (p2 == 2 && p3 == 1)

        {
            Bomb = true;
        }

        if (p2 == 1 && p3 == 2)

        {
            Bomb = true;
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalBehaviour : MonoBehaviour
{

    public GameObject Point_3;
    bool x;
    bool y;
    public static bool WrongStep;
    
    // Start is called before the first frame update
    void Start()
    {
        WrongStep = false;
        Point_3.SetActive(false);
        Debug.Log("init");
       
    }
    void Update()
    {
        y = Global.Bomb;
        if (this.gameObject.tag=="Potassium_"&& x == true && y==true)

        {
          
            Point_3.SetActive(true);
            WrongStep = true;

        }
        if(this.gameObject.tag == "Metal_" && x ==true)
        {
            Point_3.SetActive(true);
        }

    }

    // Update is called once per frame

    void OnParticleCollision(GameObject col)
    {
            x = true;
            Debug.Log("Fire");
       


        
    }
    /*
        void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Fire")
        {

            Debug.Log("Fire");


        }
    }*/

    }

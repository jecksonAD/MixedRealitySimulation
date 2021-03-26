using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialCollider : MonoBehaviour
{
    public static bool Step_1;
    public static bool Step_2;
    public static bool Step_3;

    public GameObject Material_1;
    public GameObject Material_2;
    public GameObject Material_3;
    public GameObject parentObject;
    Vector3 Test;
    bool MetalSpawn;
    int count;
    Collider m_Collider;
    // Start is called before the first frame update
    void Start()
    {
        m_Collider = GetComponent<Collider>();
        Step_1 = false;

        MetalSpawn = true;
        count = 0;
        // Test = GameObject.FindWithTag("Position_1").transform.position;
       
    }

    // Update is called once per frame
    void Update()
    {
      //  Debug.Log(count);
        if(Step_1==true)
        {
            m_Collider.enabled = false;
        }

        if (Step_3 == true)
        {
            m_Collider.enabled = false;
        }
    }

    void OnCollisionEnter(Collision col)
    {
       
        if (col.gameObject.tag=="Potassium")
        {
            if (MetalSpawn)
            {
                for (int i = 0; i<3; i++)
                { 
                GameObject x = Instantiate(Material_1, transform.position, transform.rotation);
                x.transform.SetParent(parentObject.transform);
            }

                MetalSpawn = false;
             //   Step_1 = true;

            }
                


        }

        if (col.gameObject.tag == "Metal")
        {
            if (MetalSpawn)
            {
                for (int i = 0; i < 3; i++)
                {
                    GameObject x = Instantiate(Material_2, transform.position, transform.rotation);
                    x.transform.SetParent(parentObject.transform);
                }

                MetalSpawn = false;
              //  Step_3 = true;

            }



        }

        if (col.gameObject.tag == "Cotton")
        {
            if (MetalSpawn)
            {
                GameObject x = Instantiate(Material_3, transform.position, transform.rotation);
                x.transform.SetParent(parentObject.transform);
                MetalSpawn = false;

            }

        }

    }
}
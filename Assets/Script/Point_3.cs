using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point_3 : MonoBehaviour
{
    public static bool Step_2;

    public static bool Obj_1;
    public static bool Obj_2;
    public static bool Obj_3;
    public AudioSource ItemPut;
    public static int p3;
    public AudioClip impact;
    public GameObject Material_1;
    public GameObject Material_2;
    public GameObject Material_2_level2;
    public GameObject Material_3;
    public GameObject parentObject;
    public static bool Put;
    //public GameObject Point_3;

    Vector3 Test;
    bool MetalSpawn;
    int count;
    Collider m_Collider;
    // Start is called before the first frame update
    void Start()
    {
        p3 = 0;
        m_Collider = GetComponent<Collider>();
        Step_2 = false;
       // Point_3.SetActive(false);
        MetalSpawn = true;
        count = 0;
        // Test = GameObject.FindWithTag("Position_1").transform.position;
        Obj_1 = Point_2.Obj_1;
        Obj_2 = Point_2.Obj_2;
        Obj_3 = Point_2.Obj_3;

    }

    // Update is called once per frame
    void Update()
    {
        //  Debug.Log(count);
        if (Step_2 == true)
        {
            m_Collider.enabled = false;
          //  Point_3.SetActive(true);
        }


    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Potassium" && Obj_1 == false)
        {
            ItemPut.PlayOneShot(impact, 0.7f);
            if (MetalSpawn)
            {
                for (int i = 0; i < 3; i++)
                {
                    GameObject x = Instantiate(Material_1, transform.position, transform.rotation);
                    x.transform.SetParent(parentObject.transform);
                }

                MetalSpawn = false;
                Step_2 = true;
                p3 = 1;
            }

          

        }

        if (col.gameObject.tag == "Metal" && Obj_2 == false)
        {
            ItemPut.PlayOneShot(impact, 0.7f);
            if (MetalSpawn)
            {
                for (int i = 0; i < 3; i++)
                {
                    GameObject x = Instantiate(Material_2, transform.position, transform.rotation);
                    x.transform.SetParent(parentObject.transform);
                }

                MetalSpawn = false;
                Step_2 = true;
                p3 = 2;
            }


          
        }

        if (col.gameObject.tag == "Cotton" && Obj_3 == false)
        {
            ItemPut.PlayOneShot(impact, 0.7f);
            if (MetalSpawn)
            {
                GameObject x = Instantiate(Material_3, transform.position, transform.rotation);
                x.transform.SetParent(parentObject.transform);
                MetalSpawn = false;
                Step_2 = true;
                p3 = 3;
            }
        
        }

    }
}
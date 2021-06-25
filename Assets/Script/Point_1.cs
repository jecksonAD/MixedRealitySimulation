using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point_1 : MonoBehaviour
{
    public static bool Step_1;
    public static bool Obj_1;
    public static bool Obj_2;
    public static bool Obj_3;
    public AudioSource ItemPut;
    public static int p1;
    public GameObject Material_1;
    public GameObject Material_2;
    public GameObject Material_3;
    public AudioClip impact;
    public GameObject parentObject;
    public GameObject Point_2;

    public static bool Put;
    
    Vector3 Test;
    bool MetalSpawn;
    int count;
    Collider m_Collider;
    // Start is called before the first frame update
    void Start()
    {
        m_Collider = GetComponent<Collider>();
        
        Step_1 = false;
        p1 = 0;
        Obj_1 = false;
        Obj_2 = false;
        Obj_3 = false;

        Point_2.SetActive(false);
        MetalSpawn = true;
        count = 0;
        // Test = GameObject.FindWithTag("Position_1").transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //  Debug.Log(count);
        if (Step_1 == true)
        {
            m_Collider.enabled = false;
            Point_2.SetActive(true);
        }

       
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Potassium")
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
                Step_1 = true;
                Obj_1 = true;
                p1 = 1;
                
            }
          


        }

        if (col.gameObject.tag == "Metal")
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
                  Step_1 = true;
                Obj_2 = true;
                p1 = 2;
            }

           

        }

        if (col.gameObject.tag == "Cotton")
        {
            ItemPut.PlayOneShot(impact, 0.7f);
            if (MetalSpawn)
            {
                GameObject x = Instantiate(Material_3, transform.position, transform.rotation);
                x.transform.SetParent(parentObject.transform);
                MetalSpawn = false;
                Step_1 = true;
                Obj_3 = true;
                p1 = 3;
            }
    
        }

    }
}
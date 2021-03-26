using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CottonCollider : MonoBehaviour
{
    bool step_1;
    bool step_2;
    public GameObject Cotton;
    float timer;
    Collider m_Collider;
    // Start is called before the first frame update
    void Start()
    {
        m_Collider = GetComponent<Collider>();
        Cotton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        step_1 = MaterialCollider.Step_1;
        step_2 = MaterialCollider.Step_2;
        if (step_1 == true)
        {

            m_Collider.enabled = true;

        }

        if (step_2 == true)
        {

            m_Collider.enabled = true;

        }
    }


    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Cotton")
        {


            Cotton.SetActive(true);

        }

        if (col.gameObject.tag == "Metal")
        {


            Cotton.SetActive(true);

        }

    }


}

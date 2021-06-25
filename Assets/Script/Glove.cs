using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glove : MonoBehaviour
{
    bool glove;
    public GameObject XGlove;
    // Start is called before the first frame update
    void Start()
    {
        glove = false;
        XGlove.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        glove = raycast.gloveB;
        if(glove==true)
        {
            XGlove.SetActive(true);
        }
    }
    void OnCollisionEnter(Collision col)
    {

    }
    }

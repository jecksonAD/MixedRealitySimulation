using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeTrigger : MonoBehaviour
{
    bool startbtnpressed;
    public GameObject Tube;
    public GameObject Metal;
    public GameObject Potassium;
    public GameObject Cotton;
    public GameObject FireSouce;
    // Start is called before the first frame update
    void Start()
    {
        Tube.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        startbtnpressed = GuideBook.startBtnPressed;
        if(startbtnpressed==true)
        {
            Tube.SetActive(true);
        }
    }
}

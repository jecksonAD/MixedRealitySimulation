using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectivesTEXTcHANGE : MonoBehaviour
{
    string text;
    public GameObject Tube;
    public GameObject Metal;
    public GameObject Potassium;
    public GameObject Cotton;
    public GameObject FireSouce;

    // Start is called before the first frame update
    void Start()
    {
        Tube.SetActive(false);
        Metal.SetActive(false);
        Potassium.SetActive(false);
        Cotton.SetActive(false);
        FireSouce.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        text = ObjectivesText.QuestText;
       this.GetComponent<TextMesh>().text = text;
    }
}

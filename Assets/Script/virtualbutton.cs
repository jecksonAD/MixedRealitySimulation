using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;
using UnityEngine.SceneManagement;



public class virtualbutton : MonoBehaviour,IVirtualButtonEventHandler
{
    public GameObject floatingText;
    public GameObject vrbtn;
    public GameObject Test;
    Scene scene;
    // Start is called before the first frame update
    void Start()
    {

        vrbtn = GameObject.Find("ResetBtn");
        vrbtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Test.SetActive(false);
        // button.RegisterEventHandler(this);
      scene = SceneManager.GetActiveScene(); 
    }
    void update()
       
    {
        if(floatingText)
        {
            showfloatingtext();
        }
    }

    void showfloatingtext()
    {
        Instantiate(floatingText, transform.position, Quaternion.identity, transform);
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        SceneManager.LoadScene(scene.name);
        Test.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Test.SetActive(false);
    }
}

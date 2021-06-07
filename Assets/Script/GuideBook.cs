using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GuideBook : MonoBehaviour
{
    public static bool startBtnPressed;

   // public GameObject vbBtnObj;
   private Renderer GuideRender;
    public GameObject GBook;
    public Texture Gtexture;
    public Material G_Material;
    public GameObject Camera;
    TextMesh BTNtXT;
    bool Retry;
    
    // Start is called before the first frame update
    void Start()
    {
        Camera.SetActive(true);
        Retry = false;
        GuideRender = GBook.GetComponent<Renderer>();
       
       // vbBtnObj = GameObject.Find("StarBtn");
        //vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

   
    // Update is called once per frame
    void Update()
    {
        startBtnPressed = raycast.startBtn;
       // Retry = raycast.RetrBtn;
        if (startBtnPressed == true)
        {
            GuideRender.material.mainTexture = Gtexture;
            //this.GetComponent<TextMesh>().text = "Retry";
          
        }
       
      //  if (Retry == true)
       // {
            //vuforiaBehavior.enabled = true;
          //  Retry = false;
          //  Scene scene = SceneManager.GetActiveScene();
          //  SceneManager.LoadScene(scene.name, LoadSceneMode.Single);
       

            //   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       // }

        
    }
    public void Rt()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name, LoadSceneMode.Single);
    }
}

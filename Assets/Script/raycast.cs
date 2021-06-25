using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class raycast : MonoBehaviour
{
    bool startcolide=false;
    bool RetryColide = false;
  bool GloveColide = false;
    bool ExitColide = false;
    public static bool gloveB = false;
    float timerCountDown = 3.0f;
    public static bool startBtn;
    public static bool RetrBtn;
    
    public float MaxDistance = 10;
    public Vector3 direction = Vector3.right;
    Ray ray;
    //public Text textUI;
    public GameObject NextButton;
    public GameObject StartButton;
    public GameObject RetryButton;
    public GameObject ExitButton;
    public GameObject GloveButton;
    public GameObject TextureBfferCamera;
    public GameObject glove;
    public GameObject Tipstxt;
    Renderer cubeStartRender;
    Renderer CubeRetryRender;
    Renderer CubeExitRender;
    Renderer CubeGloveRender;
    Renderer NextLevelRender;
    Color Oribtn;
    Color btnColow;
    Color btnPressCo;
    RaycastHit xs;
    public AudioSource Feedback;
    Scene scene;
    bool NEXTlevel;
    bool nextColide;
    // Start is called before the first frame update
    void Start()
    {
       cubeStartRender = StartButton.GetComponent<Renderer>();
       CubeRetryRender = RetryButton.GetComponent<Renderer>();
       CubeExitRender = ExitButton.GetComponent<Renderer>();
        NEXTlevel = true;
        startBtn = false;
        StartButton.SetActive(true);
        RetryButton.SetActive(false);
        ExitButton.SetActive(false);
        btnPressCo= new Color(0.6f, 0.258f, 0.858f, 1.0f);
        Oribtn = new Color(0.858f, 0.858f, 0.858f, 1.0f);
        btnColow = new Color(0.454f, 0.392f, 0.364f, 1.0f);
        scene = SceneManager.GetActiveScene();
        if (scene.name == "Level_2")
        {
            CubeGloveRender = GloveButton.GetComponent<Renderer>();
        }
        if (scene.name == "MAIN")
        {
            NextLevelRender = NextButton.GetComponent<Renderer>();
        }
        //  glove.SetActive(false);
        //Tipstxt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        NEXTlevel = MetalBehaviour.order;
       
      if (scene.name=="Level_2" && startBtn == true && GloveColide==false)
        {
            GloveButton.SetActive(true);
        }

        if (scene.name == "MAIN" && startBtn == true && NEXTlevel == true)
        {
            NextButton.SetActive(true);
        }
        // TextureBfferCamera = GameObject.Find("TextureBufferCamera");
        //  TextureBfferCamera.transform.position = new Vector3(1000, 1000, 1000);
        ray = new Ray(transform.position, transform.forward);
        // Ray x = Camera.main.ScreenPointToRay(transform.position);
     

        if (startcolide==true)
        {
            timerCountDown -= Time.deltaTime;
            
            if(timerCountDown < 0)
            {
                
                timerCountDown = 0;
            }
        }

        if (RetryColide == true)
        {
            timerCountDown -= Time.deltaTime;
            if (timerCountDown < 0)
            {
             
                timerCountDown = 0;
            }
        }
        if (GloveColide == true)
        {
            timerCountDown -= Time.deltaTime;
            if (timerCountDown < 0)
            {

                timerCountDown = 0;
            }
        }

        if (nextColide == true)
        {
            timerCountDown -= Time.deltaTime;
            if (timerCountDown < 0)
            {

                timerCountDown = 0;
            }
        }
        
        if (ExitColide == true)
        {
            timerCountDown -= Time.deltaTime;
            if (timerCountDown < 0)
            {

                timerCountDown = 0;
            }
        }

        if (startcolide==true && timerCountDown <=0)
        {
            Feedback.Play();
            StartButton.SetActive(false);
            RetryButton.SetActive(true);
            ExitButton.SetActive(true);
           
             //  glove.SetActive(true);
             // Tipstxt.SetActive(true);
             startBtn = true;
           
        }

        if (RetryColide == true && timerCountDown <= 0)
        {
           // Feedback.Play();
            Rt();
        }

        if (GloveColide == true && timerCountDown <= 0)
        {
            // Feedback.Play();
            gloveB = true;
            GloveButton.SetActive(false);
        }
        if (nextColide == true && timerCountDown <= 0)
        {
            // Feedback.Play();
            NextLevel();


        }

        if (ExitColide == true && timerCountDown <= 0)
        {
            // Feedback.Play();
           
            Application.Quit();

        }



        if (Physics.Raycast (ray,out xs))
        {
            if(xs.collider.gameObject.name == "StartButton")
            {
                cubeStartRender.material.SetColor("_Color", btnColow);
                startcolide = true;
                RetryColide = false;
                ExitColide = false;

                if (gloveB==true)
                {
                    GloveColide = true;
                }
                else
                {
                    GloveColide = false;
                }
               

            }
           

            else if (xs.collider.gameObject.name == "RetryButton")
            {
                CubeRetryRender.material.SetColor("_Color", btnColow);
                startcolide = false;
                RetryColide = true;
                ExitColide = false;

                if (gloveB == true)
                {
                    GloveColide = true;
                }
                else
                {
                    GloveColide = false;
                }



            }
            else if (xs.collider.gameObject.name == "GloveButton")
            {
                CubeGloveRender.material.SetColor("_Color", btnColow);
                startcolide = false;
                RetryColide = false;

             
                    GloveColide = true;
                ExitColide = false;



            }

            else if (xs.collider.gameObject.name == "NextButton")
            {
                if(scene.name == "MAIN")
                {
                    NextLevelRender.material.SetColor("_Color", btnColow);
                    startcolide = false;
                    RetryColide = false;
                    nextColide = true;
                    ExitColide = false;
                }
               


            }

           else if (xs.collider.gameObject.name == "ExitButton")
            {
                CubeExitRender.material.SetColor("_Color", btnColow);
               
                ExitColide = true;
                startcolide = false;
                RetryColide = false;
                nextColide = false;


            }


            else
            {
                startcolide = false;
                RetryColide = false;
                nextColide = false;
                ExitColide = false;

                if (gloveB == true)
                {
                    GloveColide = true;
                }
                else
                {
                    GloveColide = false;
                }
                
                timerCountDown = 3f;
            }
          //  textUI.text = xs.collider.gameObject.name;
        }
        else
        {
           // textUI.text = " ";
            CubeRetryRender.material.SetColor("_Color", Oribtn);
            cubeStartRender.material.SetColor("_Color", Oribtn);
            CubeExitRender.material.SetColor("_Color", Oribtn);

            if (scene.name == "Level_2")
            { 
                CubeGloveRender.material.SetColor("_Color", Oribtn); 
            }

            if (scene.name == "MAIN")
            {
                NextLevelRender.material.SetColor("_Color", Oribtn);
            }
            timerCountDown = 3f;
        }
        /*var ray = Camera.main.ScreenPointToRay(this.transform.position);
        RaycastHit hit;
        if(Physics.Raycast (ray,out hit))
        {

        }*/
       // Debug.DrawRay(transform.position,transform.forward*MaxDistance,Color.green);
    }

    public void Rt()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name, LoadSceneMode.Single);
    }

    public void NextLevel()
    {
        
        SceneManager.LoadScene("Level_2", LoadSceneMode.Single);
    }
}

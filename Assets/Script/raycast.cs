using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class raycast : MonoBehaviour
{
    bool startcolide=false;
    bool RetryColide = false;
    float timerCountDown = 3.0f;
    public static bool startBtn;
    public static bool RetrBtn;
    public float MaxDistance = 10;
    public Vector3 direction = Vector3.right;
    Ray ray;
   public Text textUI;
    public GameObject StartButton;
    public GameObject RetryButton;
    public GameObject ExitButton;
    public GameObject TextureBfferCamera;
    RaycastHit xs;
    // Start is called before the first frame update
    void Start()
    {
        startBtn = false;
        StartButton.SetActive(true);
        RetryButton.SetActive(false);
        ExitButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        TextureBfferCamera = GameObject.Find("TextureBufferCamera");
        TextureBfferCamera.transform.position = new Vector3(1000, 1000, 1000);
        ray = new Ray(transform.position, transform.forward);


        if(startcolide==true)
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

        if (startcolide==true && timerCountDown <=0)
        {
            StartButton.SetActive(false);
            RetryButton.SetActive(true);
            ExitButton.SetActive(true);
            startBtn = true;
           
        }

        if (RetryColide == true && timerCountDown <= 0)
        {
            Rt();
        }
     

        if (Physics.Raycast (ray,out xs))
        {
            if(xs.collider.gameObject.name == "StartButton")
            {
                startcolide = true; 
              
            }
           

            else if (xs.collider.gameObject.name == "RetryButton")
            {
                RetryColide = true;
                
            }

            else
            {
                startcolide = true;
                RetryColide = false;
                timerCountDown = 3f;
            }
            textUI.text = xs.collider.gameObject.name;
        }
        else
        {
            textUI.text = " ";
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
}

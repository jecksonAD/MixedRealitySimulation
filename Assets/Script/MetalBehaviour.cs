using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MetalBehaviour : MonoBehaviour
{
    bool glove;
    public GameObject Point_3;
    public AudioSource explosion;
    bool x;
    bool y;
    public static bool WrongStep=false;
    bool GLOVE;
    public static bool order = false;
    Scene scene;

    void Awake()
    {
        order = false;
        glove = false;
        WrongStep = false;
        Point_3.SetActive(false);
        y = false;
        x = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        order = false;
        glove = false;
        WrongStep = false;
        Point_3.SetActive(false);
        y = false;
        x = false;
        scene = SceneManager.GetActiveScene();


    }
    void Update()
    {
        y = Global.Bomb;
        GLOVE = raycast.gloveB;
        // Debug.Log(WrongStep);

        if (scene.name == "Level_2")
        {
            glove = raycast.gloveB;
        }
        else
        {
            glove = true;
        }

        if (this.gameObject.tag == "Potassium_" && x == true && y == true && glove==true)

        {

            Point_3.SetActive(true);
            Debug.Log("Inside");
            WrongStep = true;
            explosion.Play();
        }


        if (this.gameObject.tag == "Metal_" && x == true && y == false && glove == true)
        {
            Point_3.SetActive(true);
            order = true;
            //  Debug.Log("MetalActive");
        }


    }
    public void nin()
        {
         order = true;
        }
    // Update is called once per frame

    void OnParticleCollision(GameObject col)
    {
            x = true;
            Debug.Log("Fire");
       


        
    }
    /*
        void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Fire")
        {

            Debug.Log("Fire");


        }
    }*/

    }

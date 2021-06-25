using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Global : MonoBehaviour
{
    GameObject[] Metal;
     GameObject[] pottasium;
    bool glove;
    bool step_1;
   // public GameObject mat_1;
    float timer;
    int p1;
    int p2;
    int p3;
  public  int hurtlevel;
    public GameObject HurtScreen;
    bool WrongStep=false;
    bool donehURT;
 //   public GameObject[] Hpbar_0;
   // public GameObject[] Hpbar_1;
   // public GameObject[] Hpbar_2;
    public TextMeshProUGUI[] TipsTxt;
    public static bool Bomb;
    bool order;
    bool fire;
    bool audiotoggle;
    bool audioexplosion;
    bool audiotoggleItem;
    bool testSound;
    public AudioSource fireb;
    public AudioSource ItemPut;
    public AudioSource Explosion;
    bool placeitem_1;
    bool placeitem_2;
    bool placeitem_3;
    Scene scene;
    // Start is called before the first frame update
     void Awake()
    {
        glove = true;
        hurtlevel = 0;
        Bomb = false;
        donehURT = false;
        audioexplosion = true;
        WrongStep = false;
      //  var color = HurtScreen.GetComponent<Image>().color;
       // color.a = 0;
        scene = SceneManager.GetActiveScene();
    }
    void Start()
    {
        glove = true;
        hurtlevel = 0;
        Bomb = false;
        donehURT = false;
        audioexplosion = true;
        WrongStep = false;
        var color = HurtScreen.GetComponent<Image>().color;
        color.a = 0;
        scene = SceneManager.GetActiveScene();
       
    }

    // Update is called once per frame
    void Update()
    {
        if(scene.name == "Level_2")
        {
            glove = raycast.gloveB;
        }
        Metal = GameObject.FindGameObjectsWithTag("Metal_");
        pottasium = GameObject.FindGameObjectsWithTag("Potassium_");
        if (Metal.Length > 0 && Metal.Length > 0)
        {

            WrongStep = MetalBehaviour.WrongStep;
            order = MetalBehaviour.order;
        }
        else
        {
            WrongStep = false;
            order = false;
        }
        if (Metal.Length > 0)
        {
            Debug.Log("Metal");
        }

        fire = DefaultTrackableEventHandler.Fire;
        order = MetalBehaviour.order;
     
        placeitem_1 = Point_1.Put;
        placeitem_2 = Point_2.Put;
        placeitem_3 = Point_3.Put;

        p1 = Point_1.p1;
        p2 = Point_2.p2;
        p3 = Point_3.p3;

        if (p1==1 && p2==2 )
           
        {
            Bomb = true;
          
        }

        if (p1 == 2 && p2 == 1)

        {
            Bomb = true;
        
        }


        if (p2 == 2 && p3 == 1)

        {
            Bomb = true;
           
        }

        if (p2 == 1 && p3 == 2)

        {
            Bomb = true;
            
        }
     
        if (glove == false && fire == true)
        {
            getHurt();
        }
       
        if(WrongStep==true && donehURT==false)
        {
           // TipsTxt[0].text = "Pottasium and Metal explode";
           // TipsTxt[1].text = "Pottasium and Metal explode";
          
            getHurt();
           
        }

        if(WrongStep==true && audioexplosion==true)
        {
            Explosion.Play();
            audioexplosion = false;
        }    
        if(order==true)
        {
          //  TipsTxt[0].text = "Observe the output";
          //  TipsTxt[1].text = "Observe the output";
        }


        if (HurtScreen.GetComponent<Image>().color.a > 0)
        {
            var color = HurtScreen.GetComponent<Image>().color;
            //  print("RecoverHurstS");
            color.a -= 0.01f;
            HurtScreen.GetComponent<Image>().color = color;
          //  print(color.a);

        }


        /*
        if (HurtScreen != null)
        {

            if(hurtlevel==0)
            {
                
                if (HurtScreen.GetComponent<Image>().color.a > 0)
            {
               var color = HurtScreen.GetComponent<Image>().color;
                //  print("RecoverHurstS");
                color.a -= 0.01f;
                HurtScreen.GetComponent<Image>().color = color;
                print(color.a);
                 
                }
              
            }
           else if (hurtlevel == 2)
            {
           
                if (HurtScreen.GetComponent<Image>().color.a > 0.3)
                {
                    var color = HurtScreen.GetComponent<Image>().color;
                    //  print("RecoverHurstS");
                    color.a -= 0.01f;
                    HurtScreen.GetComponent<Image>().color = color;
                    print(color.a);
                 
                }
                
            }
           else if (hurtlevel == 3)
            {
            
                if (HurtScreen.GetComponent<Image>().color.a > 0.5)
                {
                    var color = HurtScreen.GetComponent<Image>().color;
                    //  print("RecoverHurstS");
                    color.a -= 0.01f;
                    HurtScreen.GetComponent<Image>().color = color;
                    print(color.a);
                  
                }
            }


        }

        */
        if (placeitem_1==true || placeitem_2 == true || placeitem_3 == true )
        {
           
          //  ItemPut.PlayOneShot(ItemSound,1.0f);
        }
      
      

        if(fire==true && audiotoggle==true)
        { 
            fireb.Play();
            audiotoggle = false;
        }
        else if (fire == false )
        {
            fireb.Stop();
            audiotoggle = true;
        }
        //print(color.a);
    }

    public void click()
    {
        ItemPut.Play();
    }
   public void getHurt()
    {
        
        var color = HurtScreen.GetComponent<Image>().color;
        color.a = 0.8f;
        HurtScreen.GetComponent<Image>().color = color;
     //   hurtlevel += 1;
        donehURT = true;
     
     


    }
    void recoverHurtScreen()
    {
        if(HurtScreen.GetComponent<Image>().color.a>0)
        {
            var color = HurtScreen.GetComponent<Image>().color;
            color.a -= 0.01f;
            HurtScreen.GetComponent<Image>().color = color;

        }
    }
}

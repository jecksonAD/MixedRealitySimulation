using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Global : MonoBehaviour
{
    bool step_1;
   // public GameObject mat_1;
    float timer;
    int p1;
    int p2;
    int p3;
  public  int hurtlevel;
    public GameObject HurtScreen;
    bool WrongStep;
    bool donehURT;

    public static bool Bomb;
    // Start is called before the first frame update
    void Start()
    {
        hurtlevel = 0;
        Bomb = false;
        donehURT = false;
       
    }

    // Update is called once per frame
    void Update()
    {

        WrongStep = MetalBehaviour.WrongStep; 
       
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

        if(WrongStep==true && donehURT==false)
        {
            getHurt();
        }
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
           else if (hurtlevel == 1)
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
           else if (hurtlevel == 2)
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

        //print(color.a);
    }

    void getHurt()
    {
        var color = HurtScreen.GetComponent<Image>().color;
        color.a = 0.8f;
        HurtScreen.GetComponent<Image>().color = color;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObjectivesText : MonoBehaviour
{
    public GameObject floatingText;
    bool point1;
    bool point2;
    bool point3;
    bool order;
    bool startbtnpressed;
   public static string QuestText;
    bool TextSpawnl;
    GameObject TEXT;
    GameObject Tube;
    bool wrongstep;
    Scene scene;
    GameObject[] Metal;
     GameObject[] pottasium;
    // Start is called before the first frame update
    void Start()
    {
        order = false;
        point1 = false;
        point2 = false;
        point3 = false;
        wrongstep = false;
        startbtnpressed = false;
        scene = SceneManager.GetActiveScene();
        TextSpawnl =false;
        QuestText = "Please Read The GuideBook First ";
    }

    // Update is called once per frame
    void Update()
    {
        Metal = GameObject.FindGameObjectsWithTag("Metal_");
        pottasium = GameObject.FindGameObjectsWithTag("Potassium_");
        if (Metal.Length>0 && Metal.Length > 0)
        {
            
            wrongstep = MetalBehaviour.WrongStep;
            order = MetalBehaviour.order;
        }
        else
        {
            wrongstep = false;
            order = false;
        }
        if(Metal.Length > 0)
        {
            Debug.Log("Metal");
        }
       // Debug.Log(Metal);
       // Debug.Log(pottasium);
        order = MetalBehaviour.order;
      
        startbtnpressed = GuideBook.startBtnPressed;
        point1 = Point_1.Step_1;
        point2 = Point_2.Step_2;
        point3 = Point_3.Step_2;

       
        if(this.gameObject.name == "Tube")
        {
            if (wrongstep == true)
            {
                QuestText = "Potassium and Metal will explore if mix .Use Guide Book to retry Again";
            }
           else if (point1 == true && point2 == true && point3 == true && startbtnpressed == true && order == true && scene.name == "MAIN")
            {
                QuestText = "Read GuideBook And Proceed To next Level ";
            }

           else if (point1==true && point2==false && point3 == false && startbtnpressed == true)
        {
            QuestText = "Put the Element into the tube ";
        }
        else if (point1 == true && point2 == true && point3 == false && startbtnpressed == true)
        {
            QuestText = "Put the Element into the tube ";
        }
        else if (point1 == true && point2 == true && point3 == true && startbtnpressed == true)
        {
            QuestText = "Fire Up the Element and Observe the output from test tube";
        }
       
        else if(startbtnpressed==false)
        {
            QuestText = "Please Read The GuideBook First ";
        }
      
        else
        {
            QuestText = "Put the Element into the tube";
        }
            /*if (floatingText)
            {
                showfloatingtext();
            }*/
            TEXT = GameObject.Find("FloatingTextTube");
            TEXT.GetComponent<TextMesh>().text = QuestText;
        }

        if (this.gameObject.name == "Potassium")
        {
             if (startbtnpressed == false)
            {
                QuestText = "Please Read The GuideBook First ";
            }
             else
            {
                QuestText = "Potassium";
            }

            TEXT = GameObject.Find("FloatingTextPotassium");
            TEXT.GetComponent<TextMesh>().text = QuestText;
        }

        if (this.gameObject.name == "Metal")
        {
            if (startbtnpressed == false)
            {
                QuestText = "Please Read The GuideBook First ";
            }
            else
            {
                if(scene.name=="MAIN")
                {
                    QuestText = "Metal Powder ";
                }
               else if (scene.name == "Level_2")
                {
                    QuestText = "Zinc Powder";
                }

            }

            TEXT = GameObject.Find("FloatingTextMetal");
            TEXT.GetComponent<TextMesh>().text = QuestText;
        }

       

        if (this.gameObject.name == "Cotton")
        {
            if (startbtnpressed == false)
            {
                QuestText = "Please Read The GuideBook First ";
            }
            else
            {
                QuestText = "Cotton";
            }

            TEXT = GameObject.Find("FloatingTextCotton");
            TEXT.GetComponent<TextMesh>().text = QuestText;
        }

    }

    void showfloatingtext()
    {
        if(TextSpawnl==false)
        { 
        var Quest= Instantiate(floatingText, transform.position, Quaternion.identity, transform);
        Quest.GetComponent<TextMesh>().text = QuestText;
          TextSpawnl = true;
        }
        else
        {

        }
    }
}

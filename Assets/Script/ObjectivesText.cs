using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectivesText : MonoBehaviour
{
    public GameObject floatingText;
    bool point1;
    bool point2;
    bool point3;
    bool startbtnpressed;
   public static string QuestText;
    bool TextSpawnl;
    GameObject TEXT;
    GameObject Tube;
    bool wrongstep;
    // Start is called before the first frame update
    void Start()
    {
        TextSpawnl =false;
    }

    // Update is called once per frame
    void Update()
    {
        wrongstep = MetalBehaviour.WrongStep;
        startbtnpressed = GuideBook.startBtnPressed;
        point1 = Point_1.Step_1;
        point2 = Point_2.Step_2;
        point3 = Point_3.Step_2;

       
        if(this.gameObject.name == "Tube")
        {

          

        if(point1==true && point2==false && point3 == false && startbtnpressed == true)
        {
            QuestText = "Put the Element into the tube ";
        }
        else if (point1 == true && point2 == true && point3 == false && startbtnpressed == true)
        {
            QuestText = "Put the Element into the tube ";
        }
        else if (point1 == true && point2 == true && point3 == true && startbtnpressed == true)
        {
            QuestText = "Fire Up the Element ";
        }
        else if(startbtnpressed==false)
        {
            QuestText = "Please Read The GuideBook First ";
        }
        else if(wrongstep==true)
            {
                QuestText = "Potassium and Metal cannot be place near with each other it will explore. Use Guide Book to restart Again";
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
                QuestText = "Metal";
            }

            TEXT = GameObject.Find("FloatingTextMetal");
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
                QuestText = "Metal";
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

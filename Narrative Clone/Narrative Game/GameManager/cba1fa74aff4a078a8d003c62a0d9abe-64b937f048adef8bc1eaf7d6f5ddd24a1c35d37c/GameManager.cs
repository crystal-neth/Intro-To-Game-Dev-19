//CAT ROOMMATE v2 by m@ boch - NYU GAMECENTER - Oct 2016
// Updated for Unity 2019 by AEFreedman

// This version doesn't work, you'll need to fix it!

using System.Collections;
using System.Collections.Generic; //We're using generic collections, specifically List<string>, so we have to add this directive
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public TMP_Text AnswerLeftText;
    public TMP_Text AnswerRightText;
    
    [Header("Answers")] //add a header to this section
    [TextArea(2, 10)]
    //display the list of strings that follows as text areas, with a min or 2 lines & a max of 10 lines for the text
    public List<string> Answers1;

    [Space(10)] //put some space below the header
    [TextArea(2, 10)]
    //display the list of strings that follows as text areas, with a min or 2 lines & a max of 10 lines for the text
    public List<string> Answers2;

    
    [Header("Cat Sprites")] //add a header to this section
    public Image CatImage; //Cat Image
    public Sprite CatAgony;
    public Sprite CatCoy;
    public Sprite CatExcited;
    public Sprite CatHappy;
    public Sprite CatJoy;
    public Sprite CatKissy;
    public Sprite CatLove;
    public Sprite CatMad;
    public Sprite CatNormal; //Cat Emoji Sprites
    public Sprite CatSad;
    public Sprite CatSleepy;
    public Sprite CatTricky;

    //private variables have to be set in code
    private int currentQuestion; //Keep track of which questions
    private int badAnswers; //Count Bad Answers
    private int goodAnswers; //Count Good Answers


    [Header("Questions")] //add a header to this section
    [TextArea(2, 10)]
    //display the list of strings that follows as text areas, with a min or 2 lines & a max of 10 lines for the text
    public List<string> Questions; //Lists for Questions & Answers

    //public variables like this one are accessible to other scripts, and often set in the inspector
    //they're great for tunable variables because we can change them while the game is running
    //sometimes it's just easier to set a reference to another object by dragging it into a public variable in the inspector
    [SerializeField]
    [Header("Components")] //add a header to this section
    [Space(10)]
    //put some space below the header
    private TMP_Text QuestionText; //Text for Questions & Answers

    [SerializeField] private GameObject GameOverPanel;
    [SerializeField] private float DelayBeforePopup;
    
    // Use this for initialization
    private void Start()
    {
        // You need to set your game state and text elements to something here.
    }

    public void ClickedRight()
    {
        if (currentQuestion >= 0 //This is the wrong number, what should it be?) //Now all questions answered, so it's time to give a result.
        {
            //call function that provides a result
        }
        else
        {
            if (currentQuestion == 0)
            {
                //set the cat sprite
                //add one to good answers
            }
            else if (currentQuestion == 1)
            {
                //set the cat sprite
                //add one to bad answers
            }
            else if (currentQuestion == 2)
            {
                //set the cat sprite
                //add one to bad answers
            }
            else if (currentQuestion == 3)
            {
                //set the cat sprite
                //add one to good answers
            }
            else if (currentQuestion == 4)
            {
                //set the cat sprite
                //add one to bad answers
            }
            else if (currentQuestion == 5)
            {
                //set the cat sprite
                //add one to bad answers
            }
            else if (currentQuestion == 6)
            {
                //set the cat sprite
                //add one to bad answers
            }

            //call function to set the question & answer text for the next question
        }
    }

    public void ClickedLeft()
    {
        if (currentQuestion >= 0 //This is the wrong number, what should it be?) //Now all questions answered, so it's time to give a result.
        {
            //call function that provides a result
        }
        else
        {
            if (currentQuestion == 0)
            {
                //set the cat sprite
                //add one to good answers
            }
            else if (currentQuestion == 1)
            {
                //set the cat sprite
                //add one to good answers
            }
            else if (currentQuestion == 2)
            {
                //set the cat sprite
                //add one to bad answers
            }
            else if (currentQuestion == 3)
            {
                //set the cat sprite
                //add one to bad answers
            }
            else if (currentQuestion == 4)
            {
                //set the cat sprite
                //add one to good answers
            }
            else if (currentQuestion == 5)
            {
                //set the cat sprite
                //add one to good answers
            }
            else if (currentQuestion == 6)
            {
                //set the cat sprite
                //add one to good answers
            }

            //call function to set the question & answer text for the next question
        }
    }

    private void NextQuestion()
    {
        currentQuestion++; //moving on to the next question
        QuestionText.text = Questions[currentQuestion]; //setting the text to the next question
        AnswerLeftText.text = Answers1[currentQuestion]; //setting the text to the next answer
        AnswerRightText.text = Answers2[currentQuestion]; //setting the text to the next answer
    }

    private void GiveResult()
    {
        AnswerLeftText.text = ""; //set answer to blank
        AnswerRightText.text = ""; //set answer to blank
        if (goodAnswers > badAnswers) //if more good answers than bad
        {
            QuestionText.text = "Let's be roommates!"; //Cat wants to live with you
            CatImage.sprite = CatHappy; //Set cat sprite
        }
        else
        {
            QuestionText.text = "I can't live with you..."; //Cat can't live with you
            //Set cat sprite
        }
        
        // I deleted something here. Wonder what it was...
    }

    public void ReloadScene()
    {
        // Use the SceneManager class to load a scene
    }

    public void ResetGameData()
    {
        currentQuestion = 0; //set current question to 0
        QuestionText.text = Questions[currentQuestion]; //set the starting values for question text 
        AnswerLeftText.text = Answers1[currentQuestion]; //set the starting values for left answer text 
        AnswerRightText.text = Answers2[currentQuestion]; //set the starting values for right answer text 
        GameOverPanel.SetActive(false);
    }

    public void QuitGame()
    {
        // There's an example of how to do this in the class materials
    }
    
    private IEnumerator ShowGameOverPanelAfterSeconds(float delay)
    {
        yield return new WaitForSeconds(delay);
        GameOverPanel.SetActive(true);
    }
}
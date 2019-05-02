using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int gameScene;

    public static int firstChoice = 0;
    public static int secondChoice = 0;
    public static int thirdChoice = 0;
    public static int fourthChoice = 0;
    public static int fifthChoice = 0;
    public static int sixthChoice = 0;

    public static bool screwYou = false;
    public static bool creakyFloor = false;
    public static bool hey = false;
    public static bool fuckYou = false;
    public static bool crackFloor = false;
    public static bool fadeFootsteps = false;
    public static bool fuckYou2 = false;
    public static bool scream = false;
    public static bool footsteps = false;
    public static bool suddenly = false;
    public static bool walkTowards = false;
    public static bool stopWalking = false;

    public static bool stopMusic = false;
    public static bool playSecondSong = false;
    public static bool playThirdSong = false;

    // Start is called before the first frame update
    void Start()
    {
        gameScene = 0;
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameScene == 1 && firstChoice == 1)
        {
            gameScene = 3;
        }
        if (gameScene == 1 && firstChoice == 2)
        {
            gameScene = 4;
        }
        if (gameScene == 1 && firstChoice == 3)
        {
            gameScene = 5;
        }

        if (gameScene == 6 && secondChoice == 1)
        {
            gameScene = 7;
        }
        if (gameScene == 6 && secondChoice == 2)
        {
            gameScene = 8;
        }
        if (gameScene == 6 && secondChoice == 3)
        {
            gameScene = 9;
        }

        if (gameScene == 10 && thirdChoice == 1)
        {
            gameScene = 11;
        }
        if (gameScene == 10 && thirdChoice == 2)
        {
            gameScene = 12;
        }
        if (gameScene == 10 && thirdChoice == 3)
        {
            gameScene = 13;
        }

        if (gameScene == 14 && fourthChoice == 1)
        {
            gameScene = 15;
        }
        if (gameScene == 14 && fourthChoice == 2)
        {
            gameScene = 16;
        }
        if (gameScene == 14 && fourthChoice == 3)
        {
            gameScene = 17;
        }
        if (gameScene == 18 && fifthChoice == 1)
        {
            gameScene = 19;
        }
        if (gameScene == 18 && fifthChoice == 2)
        {
            gameScene = 20;
        }
        if (gameScene == 18 && fifthChoice == 3)
        {
            gameScene = 21;
        }

        if (gameScene == 22 && sixthChoice == 1)
        {
            gameScene = 23;
        }
        if (gameScene == 22 && sixthChoice == 2)
        {
            gameScene = 24;
        }
        if (gameScene == 22 && sixthChoice == 3)
        {
            gameScene = 25;
        }
    }
}

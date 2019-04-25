using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int gameScene;
    public static int firstChoice = 0;

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
    }
}

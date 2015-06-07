using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public static int currentScore;
    public static int highScore;

    public static int currentLevel = 0;
    public static int unlockedLevel;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);   
	}

    public static void CompleteLevel()
    {
        if (currentLevel < 2)
        {
            currentLevel += 1;
            Application.LoadLevel(currentLevel);
        }
        else
        {
            print ("You win");
        }
    }
}

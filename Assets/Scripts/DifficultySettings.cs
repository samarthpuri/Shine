using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySettings : MonoBehaviour {

    private const int DIFFICULTY_LEVEL_EASY = 0;
    private const int DIFFICULTY_LEVEL_NORMAL = 1;
    private const int DIFFICULTY_LEVEL_HARD = 2;

    public static DifficultySettings instance;

    public static float cameraScrollSpeed;
    public static float playerSpeed;
    public static float speedupTimer;
    public static GameObject tile;

    public GameObject[] tilePrefabs;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;

        int difficultyLevel = DIFFICULTY_LEVEL_NORMAL;
        switch (difficultyLevel)
        {
            case DIFFICULTY_LEVEL_EASY:
                speedupTimer = 30.0f;
                break;
            case DIFFICULTY_LEVEL_NORMAL:
                speedupTimer = 15.0f;
                break;
            case DIFFICULTY_LEVEL_HARD:
                speedupTimer = 5.0f;
                break;
            default:
                Debug.LogError("Invalid difficulty level: " + difficultyLevel);
                break;
        }

        tile = tilePrefabs[difficultyLevel];
    }
}

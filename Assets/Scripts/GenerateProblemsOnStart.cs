using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateProblemsOnStart : MonoBehaviour
{
    [SerializeField]
    GameObject Problem;

    [SerializeField]
    GameObject StartPlatform;
    private int zPosition = 15;
    private void Start()
    {
        GameManager.Score = 0;

        Instantiate(Problem, new Vector3(0, 0, zPosition), Quaternion.identity);

        // Generate 3 platforms at the begining
        // for (int i = 0; i < 3; i++)
        // {
        //     Instantiate(Problem, new Vector3(0, 0, zPosition), Quaternion.identity);
        //     zPosition += 30;
        // }

        // Destroys the starting platform and itself after 10 and 12 seconds repsectively
        Destroy(StartPlatform, 10);
        Destroy(this, 12);
    }
}

using UnityEngine;

public class GenerateProblem
{
    public static void GenerateNewProblem(string json)
    {
        Problems problems = JsonUtility.FromJson<Problems>(json);

        int randomSelection = Random.Range(0, problems.problems.Length - 1);

        GameManager.CurrentProblem = problems.problems[randomSelection];
    }
}

using UnityEngine;

public class GenerateProblems : MonoBehaviour
{
    [SerializeField]
    GameObject Problem;
    private int zPosition = 15;
    private void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(Problem, new Vector3(0, 0, zPosition), Quaternion.identity);
            zPosition += 30;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateNewProblem : MonoBehaviour
{
    [SerializeField]
    GameObject GeneratePrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            int zPosition = Mathf.RoundToInt(this.transform.position.z) + 15;
            Instantiate(GeneratePrefab, new Vector3(0, 0, zPosition), Quaternion.identity);
        }

        Destroy(this);

        // For more problems to be generated

        // int problemsToGenerate = 3;
        // int zPosition = Mathf.RoundToInt(this.transform.position.z) * problemsToGenerate + 15;

        // for (int i = zPosition; i < zPosition + (problemsToGenerate * 30); i += 30)
        // {
        //     Instantiate(GeneratePrefab, new Vector3(0, 0, i), Quaternion.identity);
        // } 
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class AnswerCollision : MonoBehaviour
{
    [SerializeField]
    GameObject DestroyedVersion;

    [SerializeField]
    GameObject GeneratePrefab;

    [SerializeField]
    GameObject DestroySelfPrefab;

    private void OnCollisionEnter(Collision other)
    {
        if (gameObject.tag == "AnswerFalse" && other.gameObject.tag == "Player")
        {
            GameManager.GameOver = true;

            SceneManager.LoadScene("GameOverScene");
        }

        if (gameObject.tag == "AnswerTrue" && other.gameObject.tag == "Player" && !GameManager.GameOver)
        {
            Instantiate(DestroyedVersion, transform.position, transform.rotation);
            Destroy(this.gameObject);
            GameManager.Score++;

            int zPosition = Mathf.RoundToInt(this.transform.position.z) * 3 + 15;

            for (int i = zPosition; i < zPosition + (3 * 30); i += 30)
            {
                Instantiate(GeneratePrefab, new Vector3(0, 0, i), Quaternion.identity);
            }

            Destroy(DestroySelfPrefab, 2);
        }
    }
}

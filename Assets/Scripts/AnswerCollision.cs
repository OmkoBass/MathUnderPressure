using UnityEngine;
using UnityEngine.SceneManagement;

public class AnswerCollision : MonoBehaviour
{
    [SerializeField]
    GameObject DestroyedVersion;

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
            Destroy(this.gameObject);
            Instantiate(DestroyedVersion, transform.position, transform.rotation);

            GameManager.Score++;

            Destroy(DestroySelfPrefab, 2);
        }
    }
}

using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    float StrafeSpeed;

    [SerializeField]
    float Speed;

    [SerializeField]
    float MaxSpeed = 2;

    [SerializeField]
    float SpeedUpIncrement = 0.05f;

    [SerializeField]
    float SpeedUpReset = 10;

    [SerializeField]
    KeyCode KeyLeft;

    [SerializeField]
    KeyCode KeyRight;

    private Rigidbody Rigidbody;

    private float speedTimer = 0;
    private bool isJumping = false;

    private void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        GameManager.GameOver = false;
    }
    void FixedUpdate()
    {
        if (GameManager.GameOver)
        {
            return;
        }

        speedTimer -= Time.deltaTime;

        if (speedTimer <= 0 && Speed <= MaxSpeed)
        {
            speedTimer = SpeedUpReset;
            Speed += SpeedUpIncrement;
        }

        if (Input.GetKey(KeyLeft))
        {
            this.transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyRight))
        {
            this.transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }

        Vector3 constantDirection = new Vector3(0, 0, Speed * Time.deltaTime);

        Rigidbody.AddForce(constantDirection, ForceMode.VelocityChange);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Platform" && isJumping)
        {
            isJumping = false;
        }
    }
}

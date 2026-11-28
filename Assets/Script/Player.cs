
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float speed = 15f;
    public float mapWidth = 5f;

    private Rigidbody2D rb;
    private GameManager gameManager;

    private float horizontalInput;
    private bool gameHasEnded;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager = FindAnyObjectByType<GameManager>();
    }

    private void Update()
    {
        if (gameHasEnded)
            return;

        horizontalInput = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        if (rb == null || gameHasEnded)
            return;

        float movement = horizontalInput * speed * Time.fixedDeltaTime;

        Vector2 newPosition = rb.position +
                              Vector2.right * movement;

        newPosition.x = Mathf.Clamp(
            newPosition.x,
            -mapWidth,
            mapWidth
        );

        rb.MovePosition(newPosition);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameHasEnded)
            return;

        gameHasEnded = true;

        if (gameManager != null)
        {
            gameManager.EndGame();
        }
        else
        {
            Debug.LogWarning("GameManager reference could not be found.", this);
        }
    }
}

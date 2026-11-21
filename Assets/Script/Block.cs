
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Block : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        rb.gravityScale += Time.timeSinceLevelLoad / 20f;
    }

    private void Update()
    {
        if (transform.position.y < -2f)
        {
            Destroy(gameObject);
        }
    }
}

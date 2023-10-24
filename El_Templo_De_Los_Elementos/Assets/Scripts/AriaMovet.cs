using UnityEngine;

public class AriaMovet : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    public float ScaleFactor = 2.0f; // Factor de escala para hacer grande al personaje
    private Rigidbody2D Rigidbody2D;
    private float Horizontal;
    private bool Grounded;

    private void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        if (Horizontal < 0.0f) transform.localScale = new Vector3(-ScaleFactor, ScaleFactor, 1.0f);
        else if (Horizontal > 0.0f) transform.localScale = new Vector3(ScaleFactor, ScaleFactor, 1.0f);

        Debug.DrawRay(transform.position, Vector3.down * 1.0f, Color.blue);
        Grounded = Physics2D.Raycast(transform.position, Vector3.down, 1.0f);

        if (Input.GetKeyDown(KeyCode.W) && Grounded)
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal * Speed, Rigidbody2D.velocity.y);
    }

    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * JumpForce);
    }
}

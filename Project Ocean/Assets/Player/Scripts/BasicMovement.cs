using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed = 10f;
    //private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;
        //moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //transform.Translate(moveInput * moveSpeed * Time.deltaTime);
    }
}

using UnityEngine;

public class Movement2d : MonoBehaviour
{
    public float movSpeed;

    float speedx, speedy;



    Rigidbody2D rb;



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    private void Update()
    {
        speedx = Input.GetAxisRaw("Horizontal") * movSpeed;

        speedy = Input.GetAxisRaw("Vertical") * movSpeed;
        rb.linearVelocity = new Vector2(speedx, speedy);



    }
}

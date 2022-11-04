using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform player;
    public CharacterController characterController;
    public float speed = 12;
    public float gravityScale = 1;
    public float jumpHeight = 4;
    private float gravity = -9.81f;
    public bool isGrounded;
    float velocity;

    public static PlayerController ins;

    private void Awake()
    {
        ins ??= this;
    }

    void Start()
    {
        player = GetComponent<Transform>();
        characterController = GetComponent<CharacterController>();
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    void Update()
    {

        float h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        Vector3 movement = new Vector3(h, 0, 0);

        characterController.Move(movement);

        velocity += gravity * Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            velocity = Mathf.Sqrt(jumpHeight * -2f * (gravity * gravityScale));
        }
        velocity += gravity * gravityScale * Time.deltaTime;
        MovePlayer();
    }

    void MovePlayer()
    {
        characterController.Move(new Vector3(0, velocity, 0) * Time.deltaTime);
    }

}

using UnityEngine;

public class CharacterController : MonoBehaviour
{
    
    private Rigidbody p_rb;
    public float p_Speed;
    private Vector2 moveDirection = Vector2.zero;
    public float jumpForce;
    private bool isPaused;
    
    public GameObject pauseScreen;
    
    void Start()
    {
        p_rb = GetComponent<Rigidbody>();
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            unPause();
        }

        if (!isPaused)
        {
            MovementHandler();
        }
        
    }

    void MovementHandler()
    {
        // Handles wasd movement
        
        moveDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        
        p_rb.linearVelocity += moveDirection.y * p_Speed * Time.deltaTime * transform.forward;
        p_rb.linearVelocity += moveDirection.x * p_Speed * Time.deltaTime * transform.right;
        
        // Handles funny space bar
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            // Checks if there's anything below the player
            if (Physics.Raycast(transform.position, Vector3.down, 1.1f))
            {
                p_rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
            
        }
    }

    void unPause()
    {
        if (!isPaused)
        {
            isPaused = true;
            pauseScreen.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            isPaused = false;
            pauseScreen.SetActive(false);
            Time.timeScale = 1;
        }
    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class ThirdPersonCamera : MonoBehaviour
{
    
    public GameObject camOrigin;
    private bool camLocked;

    void Start()
    {
        camLocked = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        
        // Will now toggle if the player wants to move the camera or not
        if (Input.GetKeyDown(KeyCode.Q))
        {
            camLocked = !camLocked;
        }
        
        if (!camLocked)
        {
            camMovement();
        }
        
    }

    void camMovement()
    {
        // Deals with mouse movement to rotation
        
        var mouse = Mouse.current;
        
        float x = 0;
        float y = 0;
        
        x += -mouse.delta.y.ReadValue() * 10f * Time.deltaTime;
        y += mouse.delta.x.ReadValue() * 10f * Time.deltaTime;

        this.transform.Rotate(0,y,0);
        
        // code for a height cap in terms of rotations
        
        if (camOrigin.transform.rotation.eulerAngles.x + x < 45f || camOrigin.transform.rotation.eulerAngles.x + x > 315f)
        {
            camOrigin.transform.Rotate(x,0,0);
        }
    }
}

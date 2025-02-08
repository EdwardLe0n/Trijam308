using UnityEngine;
using UnityEngine.InputSystem;

public class ThirdPersonCamera : MonoBehaviour
{
    
    public GameObject camOrigin;

    // Update is called once per frame
    void Update()
    {
        
        // Deals with mouse movement to rotation
        
        var mouse = Mouse.current;
        
        float x = 0;
        float y = 0;
        float z = 0;
        
        x += -mouse.delta.y.ReadValue() * 50f * Time.deltaTime;
        y += mouse.delta.x.ReadValue() * 100f * Time.deltaTime;

        this.transform.Rotate(0,y,0);
        camOrigin.transform.Rotate(x,0,0);

    }
}

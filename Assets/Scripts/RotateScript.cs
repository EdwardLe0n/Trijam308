using UnityEngine;

public class RotateScript : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0f, 10f * Time.deltaTime, 0f));
    }
}

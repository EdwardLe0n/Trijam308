using UnityEngine;

public class FlameTimer : MonoBehaviour
{
    
    public float flameTimer;
    public float flameStartTime;
    
    public GameObject flame;
    public GameObject flameParticles;
    
    void Start()
    {
        flameTimer = flameStartTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (flameTimer <= 0)
        {
            KillFire();
        }
        else
        {
            flameTimer -= Time.deltaTime;
        }
    }

    void KillFire()
    {
        flame.SetActive(false);
        flameParticles.SetActive(false);
    }
    
}

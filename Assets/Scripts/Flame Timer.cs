using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class FlameTimer : MonoBehaviour
{
    
    public float flameTimer;
    public float flameStartTime;
    
    public GameObject flame;
    public GameObject flameParticles;
    
    public TextMeshProUGUI flameText;
    
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
            
            int minutes = Mathf.FloorToInt(flameTimer / 60);
            int seconds = Mathf.FloorToInt(flameTimer % 60);
            
            flameText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            
        }
    }

    void KillFire()
    {
        flame.SetActive(false);
        flameParticles.SetActive(false);
    }
    
}


using UnityEngine;

public class TW_Trigger_Enable_Object : MonoBehaviour
{

    public GameObject door;
    
    public bool destroy_trigger_when_activated;
    public float delay = 0.5F;
    public bool enable = false;
    private float enable_time;
    private bool triggered;


    void Start()
    {
        if (enable) door.SetActive(false);
    }

    void Update()
    {
        if (triggered && Time.time > enable_time)
        {

            if (enable)
                door.SetActive(true);
            else
                door.SetActive(false);

            if (destroy_trigger_when_activated)
            {
                
                gameObject.SetActive(false);
            }
        }
    }

    void OnTriggerEnter(Collider _cl_object_touching)
    {
        

            triggered = true;

            enable_time = Time.time + delay;
        
    }

}
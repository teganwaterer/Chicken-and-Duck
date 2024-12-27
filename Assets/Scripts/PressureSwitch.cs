using UnityEngine;
public class PressureSwitch : MonoBehaviour
{
    [SerializeField] private Door currentDoor;
    
    private void OnTriggerStay(Collider other)
    {
        currentDoor.AddPressureSwitch(this);
        
    }
    private void OnTriggerExit(Collider other)
    {
        currentDoor.RemovePressureSwitch(this);
        
    }


}
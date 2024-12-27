using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TW_Water : MonoBehaviour
{

    public float x;
    public float y;
    

    

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Water"))
        {
            transform.position = new Vector3(x, y, 0);
        }

    }



}

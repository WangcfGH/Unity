using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour 
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Monster")
        {
            other.gameObject.SendMessageUpwards("DestroyMonster", other.gameObject);
            GameObject.Destroy(other.gameObject);            
        }
    }
}

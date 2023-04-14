using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTrigger : MonoBehaviour {
    void OnTriggerEnter(Collider coll)
    {
        if (coll.name == "Player")
        {
            MonstersManager.Instance.CreateAllMonsters();
        }
    }
}

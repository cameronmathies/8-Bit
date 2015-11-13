using UnityEngine;
using System.Collections;

public class PLayerDie : MonoBehaviour {

    void OnTriggerEnter(Collider collision)
    {
            DestroyObject(collision.gameObject);
    }
}

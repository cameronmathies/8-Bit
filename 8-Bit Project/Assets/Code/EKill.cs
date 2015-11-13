using UnityEngine;
using System.Collections;

public class EKill : MonoBehaviour {
    public GameObject Goomba;

    void OnTriggerEnter(Collider collision)
    {
        DestroyObject(collision.gameObject);
    }
}

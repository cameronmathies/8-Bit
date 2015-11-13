using UnityEngine;
using System.Collections;

public class EKill : MonoBehaviour {
    public GameObject Goomba;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Enemy")
        {
            DestroyObject(collision.gameObject);
        }
    }
}

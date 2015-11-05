using UnityEngine;
using System.Collections;

public class RPlayer : MonoBehaviour {

    public float moveSpeed;
    public float speed = 10f;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightAlt))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
    }
}

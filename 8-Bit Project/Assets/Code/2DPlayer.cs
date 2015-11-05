using UnityEngine;
using System.Collections;

public class 2DPlayer : MonoBehaviour {

	public float moveSpeed;
public float Speed = 1f;

void FixedUpdate()
{
    if (Input.GetKey(KeyCode.LeftAlt))
    {
        transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
    }
    if (Input.GetKey(KeyCode.RightAlt))
    {
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
    }
}
}

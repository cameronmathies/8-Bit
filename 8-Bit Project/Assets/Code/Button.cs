using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public void Enter()
    {
        Application.LoadLevel("1 -1");
    }

    public void Story()
    {
        Application.LoadLevel("Story");
    }
}

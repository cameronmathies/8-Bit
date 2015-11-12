using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{

    public void OnClick()
    {
        Application.LoadLevel("characters");
    }
}
using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{

    public void OnClick()
    {
        Application.LoadLevel("characters");
    }
    public void mario()
    {
        Application.LoadLevel("1-1");
    }
    public void luigi()
    {
        Application.LoadLevel("1-2");
    }

}
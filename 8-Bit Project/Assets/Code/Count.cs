using UnityEngine;
using System.Collections;

public class Count : MonoBehaviour {

    float timeRemaining = 500f; // Start time

    void Update()
    {
        timeRemaining -= Time.deltaTime; //lowering the time
    }

    void OnGUI()
    {
        if (timeRemaining > 0)
        {
            GUI.Label(new Rect(100,100, 200, 100), // Ware to show text
                         "Time Remaining : " + timeRemaining);
        }
        else
        {
            GUI.Label(new Rect(100, 100, 200, 100), "Time's Up"); //end
            Application.LoadLevel("Main Menu");
        }
    }
}

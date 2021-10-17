using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminaleControl : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
        ShowMainMenu("Serhii");
    }


    void ShowMainMenu(string playerName)
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Hello, " + playerName + "!");
        Terminal.WriteLine("Which Terminal do you wont hack today?");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("Enter 1 if you hack City Lirbary");
        Terminal.WriteLine("Enter 2 if you hack Police station");
        Terminal.WriteLine("Enter 2 if you hack UFO");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("Enter your choice");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

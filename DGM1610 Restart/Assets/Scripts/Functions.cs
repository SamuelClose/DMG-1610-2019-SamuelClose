using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{

    private int myNumber;

    public string playerName;
    
    
    
    void Start()
    {
        print(WelcomePlayer());
        myNumber = AddNumbers(4,9);
    }



    private string WelcomePlayer()
    {
        return playerName + "Welcome To the Game";
    }







    private int AddNumbers(int a, int b)
    {

       
        return a+b;
  
    }

}






   
    
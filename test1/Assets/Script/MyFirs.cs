using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirs : MonoBehaviour
{
   public int myAge =15;
   public int legalAgeToDrive=18;

    // Start is called before the first frame update
    void Start()
    {
        if(myAge>=legalAgeToDrive)
        {
            print("You Can Dive");

        }
        else
        {
            print("You Can't Drive");

        }


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

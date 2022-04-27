using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FistMoveSpaceBar : MonoBehaviour
{
    public int Number = 10;
    public float KeyInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        KeyInput =Input.GetAxis("Jump");


        if(KeyInput>0)
        {
            Number++;
            print(Number);
        }
    }
}

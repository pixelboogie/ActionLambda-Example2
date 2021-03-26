using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


// create a delegate of type void that has no parameters and returns the gameObjects name

public class Main : MonoBehaviour
{
    public Action OnGetName;

    void Start()
    {
        OnGetName = () => Debug.Log("Name: " + gameObject.name);
        OnGetName(); 
    }

    // void GetName()
    // {
    //     Debug.Log("Name: " + gameObject.name);
    // }

}

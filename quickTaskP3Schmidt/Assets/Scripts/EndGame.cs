using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    private Rigidbody rb;
    private int a;

    //public static bool abc;
    // Start is called before the first frame update
    void Start()
    {
  
    }
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        for (int i = 1; i <= 2; i++)
        {
            Debug.Log("The Game is Over");
            QuitGame();
        }
    }

  

    // Update is called once per frame
    void Update()
    {
      
    }
  
}

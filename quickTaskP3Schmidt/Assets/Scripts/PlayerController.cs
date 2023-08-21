using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Build.Content;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 2.0f;
    public static bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W)) {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space)) {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (gameOver)
        {
            Time.timeScale = 0;
            System.Console.WriteLine("The Game is Over");
        }


        private static void OnControllerColliderHit(ControllerColliderHit hit)
        {
            if (hit.transform.tag == "Finish")
            {
                PlayerController.gameOver = true;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{   
    Vector3 InitialPosition;

    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    void Awake()
    {
        InitialPosition = transform.position;
    }

    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;

        Vector3 directionToInitialPosition = InitialPosition - transform.position;
        GetComponent<Rigidbody2D>().AddForce(directionToInitialPosition * 300);
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Rigidbody2D>().gravityScale = 0;           //Turns Gravity Off
            transform.position = InitialPosition;                   //Resets Position
            transform.rotation = Quaternion.identity;               //Resets Rotation
            GetComponent<Rigidbody2D>().angularVelocity = 0;        //Stop Rotation Force
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;    //Stop Movement Force
            Debug.Log("position reset");                            //Log In Console
        }
    }

    void OnMouseDrag()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPosition.x, newPosition.y);
    }
}
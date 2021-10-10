using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{   
    public float _forceMuliplier = 250F;

    Vector3 _initialPosition;

    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    void Awake()
    {
        _initialPosition = transform.position;
    }

    void Update()
    {
        GetComponent<LineRenderer>().SetPosition(0, _initialPosition);
        GetComponent<LineRenderer>().SetPosition(1, transform.position);

        if (Input.GetKeyDown(KeyCode.R))                            //Reset Script
        {
            GetComponent<Rigidbody2D>().gravityScale = 0;           //Turns Gravity Off
            transform.position = _initialPosition;                  //Resets Position
            transform.rotation = Quaternion.identity;               //Resets Rotation
            GetComponent<Rigidbody2D>().angularVelocity = 0;        //Stop Rotation Force
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;    //Stop Movement Force
            Debug.Log("position reset");                            //Log In Console
        }
    }

    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;

        Vector3 directionToInitialPosition = _initialPosition - transform.position;
        GetComponent<Rigidbody2D>().AddForce(directionToInitialPosition * _forceMuliplier);
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }

    void OnMouseDrag()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPosition.x, newPosition.y);
    }
}
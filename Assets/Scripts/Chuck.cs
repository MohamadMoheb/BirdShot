using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chuck : MonoBehaviour
{
    [SerializeField] private float _forceMuliplier = 250F;
    [SerializeField] private Vector3 _initialPosition;

    public bool _activated;

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
        GetComponent<LineRenderer>().SetPosition(0, transform.position);    //Sets Line Renderer Extreme 1 on initial bird position
        GetComponent<LineRenderer>().SetPosition(1, _initialPosition);      //Sets Line Renderer Extreme 2 on current bird position

        if (Input.GetKeyDown(KeyCode.R))                                    //Resets Script
        {
            GetComponent<Rigidbody2D>().gravityScale = 0;                   //Turns Gravity Off
            transform.position = _initialPosition;                          //Resets Position
            transform.rotation = Quaternion.identity;                       //Resets Rotation
            GetComponent<Rigidbody2D>().angularVelocity = 0;                //Stops Rotation Force
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;            //Stops Movement Force
            Debug.Log("position reset");                                    //Logs In Console
            _activated = false;
        }

         if (Input.GetKeyDown(KeyCode.Space) && GetComponent<Rigidbody2D>().velocity.magnitude > 2 && _activated == false)
        {
            _activated = true;
            GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity * 2;
            Debug.Log("Ability Activated");
        }
    }

    void OnMouseDown()
    {
        GetComponent<LineRenderer>().enabled = true;
    }

    void OnMouseUp()
    {
        Vector3 directionToInitialPosition = _initialPosition - transform.position;
        GetComponent<Rigidbody2D>().AddForce(directionToInitialPosition * _forceMuliplier);
        GetComponent<Rigidbody2D>().gravityScale = 1;

        GetComponent<LineRenderer>().enabled = false;
    }

    void OnMouseDrag()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPosition.x, newPosition.y);
    }
}
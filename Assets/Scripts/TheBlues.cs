using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBlues : MonoBehaviour
{ 
    float offset = 2;

    public float _forceMuliplier = 250F;

    public Vector3 _initialPosition;
    public Vector2 _velocity;

    public GameObject _Jay;
    public GameObject _Jake;
    public GameObject _Jim;

    public Rigidbody2D rb; //reference rigidbody2d

    public bool _activated;

    void Start()
    {
        rb.gravityScale = 0;
    }

    void Awake()
    {
        _initialPosition = transform.position;
    }

    void Update()
    {
        GetComponent<LineRenderer>().SetPosition(0, transform.position);    //Sets Line Renderer Extreme 1 on initial bird position
        GetComponent<LineRenderer>().SetPosition(1, _initialPosition);      //Sets Line Renderer Extreme 2 on current bird position

        if (Input.GetKeyDown(KeyCode.R))                //Reset Script
        {
            rb.gravityScale = 0;                        //Turns Gravity Off
            transform.position = _initialPosition;      //Resets Position
            transform.rotation = Quaternion.identity;   //Resets Rotation
            rb.angularVelocity = 0;                     //Stops Rotation Force
            rb.velocity = Vector3.zero;                 //Stops Movement Force
            Debug.Log("position reset");                //Logs In Console
            _activated = false;
        }

        _velocity = GetComponent<Rigidbody2D>().velocity;

        if (Input.GetKeyDown(KeyCode.Space) && GetComponent<Rigidbody2D>().velocity.magnitude > 1 && _activated == false)
        {
            _activated = true;
            print("Ability Activated");

            GameObject clone1 = Instantiate(_Jay, transform.position + Vector3.up * offset, transform.rotation);
            GameObject clone2 = Instantiate(_Jake, transform.position, transform.rotation);
            GameObject clone3 = Instantiate(_Jim, transform.position + Vector3.up * -offset, transform.rotation);

            gameObject.SetActive(false);
        }

        print("rbvelo"+ _velocity);
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
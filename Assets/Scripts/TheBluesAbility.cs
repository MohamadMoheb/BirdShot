using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBluesAbility : MonoBehaviour
{

    public bool _activated;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && GetComponent<Rigidbody2D>().velocity.magnitude > 2 && _activated == false)
        {
            _activated = true;
            Debug.Log("Ability Activated");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            _activated = false;
        }
    }
}
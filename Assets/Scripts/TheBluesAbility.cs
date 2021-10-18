using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBluesAbility : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Vector3 _spawnpoint1edit;//spawn location editor for clone 1
    [SerializeField] private Vector3 _spawnpoint2edit;//spawn location editor for clone 2
    [SerializeField] private Vector3 _spawnpoint1; // set spawn point for clone 1
    [SerializeField] private Vector3 _spawnpoint2; //set spawn point for clone 2

    public bool _activated;

    // Update is called once per frame
    void Update()
    {
        _spawnpoint1edit.Set(0,+2,0);
        _spawnpoint2edit.Set(0,-2,0);

        if (Input.GetKeyDown(KeyCode.Space) && GetComponent<Rigidbody2D>().velocity.magnitude > 2 && _activated == false)
        {
            _activated = true;
            Debug.Log("Ability Activated");

            _spawnpoint1 = transform.position + _spawnpoint1edit;
            _spawnpoint2 = transform.position + _spawnpoint2edit;

            Instantiate(prefab, _spawnpoint1, Quaternion.identity);
            Instantiate(prefab, _spawnpoint2, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            _activated = false;
        }

        Debug.Log("rotation"+ transform.rotation);
    }
}
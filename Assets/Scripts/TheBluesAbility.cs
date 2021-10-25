using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBluesAbility : MonoBehaviour
{
    float offset = 2;
    public GameObject Player;

    public Rigidbody2D rb; //reference rigidbody2d

    [SerializeField] private GameObject _prefab;
    private Vector3 _spawnpoint1edit;//spawn location editor for clone 1
    private Vector3 _spawnpoint2edit;//spawn location editor for clone 2
    private Vector3 _spawnpoint3edit;//spawn location editor for clone 3

    public bool _activated;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && GetComponent<Rigidbody2D>().velocity.magnitude > 2 && _activated == false)
        {
            _activated = true;
            Debug.Log("Ability Activated");

            GameObject clone1 = Instantiate(_prefab, transform.position + Vector3.up * offset, transform.rotation);
            GameObject clone2 = Instantiate(_prefab, transform.position, transform.rotation);
            GameObject clone3 = Instantiate(_prefab, transform.position + Vector3.up * offset * -1, transform.rotation);

            clone1.GetComponent<Rigidbody2D>().velocity = rb.velocity;
            clone2.GetComponent<Rigidbody2D>().velocity = rb.velocity;
            clone3.GetComponent<Rigidbody2D>().velocity = rb.velocity;

            Player.SetActive(false);

            //clone1.transform.parent = gameObject.transform;
            //clone2.transform.parent = gameObject.transform; //parenting script
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            _activated = false;
        }
    }
}
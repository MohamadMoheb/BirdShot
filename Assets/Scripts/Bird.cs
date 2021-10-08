using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{   
    public Vector3 InitialPosition;

    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    void Fixedupdate()
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

        transform.position = InitialPosition;
        //Vector3 directionToInitialPosition = InitialPosition - transform.position;
        //GetComponent<Rigidbody2D>().AddForce(directionToInitialPosition);
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }

    void OnMouseDrag()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPosition.x, newPosition.y);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jake : MonoBehaviour
{
    [SerializeField] private GameObject _Jake;

    public static Vector2 _jakevelocity;       //NEEDS TO BE SENT TO VARIABLES

    public Rigidbody2D rb; //reference rigidbody2d

    void Update()
    {
        _jakevelocity = GetComponent<Rigidbody2D>().velocity;

        if(Input.GetKeyDown(KeyCode.R))                //Reset Script
        {
            _Jake.SetActive(false);
            Debug.Log("position reset (jakedel)");            //Logs In Console
        }
    }
}
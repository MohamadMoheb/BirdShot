using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jim : MonoBehaviour
{
    [SerializeField] private GameObject _Jim;

    public static Vector2 _jimvelocity;       //NEEDS TO BE SENT TO VARIABLES

    public Rigidbody2D rb; //reference rigidbody2d

    void Update()
    {
        _jimvelocity = GetComponent<Rigidbody2D>().velocity;

        if (Input.GetKeyDown(KeyCode.R))                //Reset Script
        {
            _Jim.SetActive(false);
            Debug.Log("position reset (jimdel)");            //Logs In Console
        }
    }
}
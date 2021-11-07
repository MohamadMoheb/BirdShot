using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jay : MonoBehaviour
{
    [SerializeField] private GameObject _Jay;

    public static Vector2 _jayvelocity;       //NEEDS TO BE SENT TO VARIABLES

    public Rigidbody2D rb; //reference rigidbody2d

    void Update()
    {
        _jayvelocity = GetComponent<Rigidbody2D>().velocity;

        if(Input.GetKeyDown(KeyCode.R))                //Reset Script
        {
            _Jay.SetActive(false);
            Debug.Log("position reset (jaydel)");            //Logs In Console
        }
    }
}
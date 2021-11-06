using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jim : MonoBehaviour
{
    [SerializeField] private GameObject _Jim;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))                //Reset Script
        {
            _Jim.SetActive(false);
            Debug.Log("position reset (jimdel)");            //Logs In Console
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jake : MonoBehaviour
{
    [SerializeField] private GameObject _Jake;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))                //Reset Script
        {
            _Jake.SetActive(false);
            Debug.Log("position reset (2)");            //Logs In Console
        }
    }
}
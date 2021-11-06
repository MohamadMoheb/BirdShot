using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jay : MonoBehaviour
{
    [SerializeField] private GameObject _Jay;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))                //Reset Script
        {
            _Jay.SetActive(false);
            Debug.Log("position reset (jaydel)");            //Logs In Console
        }
    }
}
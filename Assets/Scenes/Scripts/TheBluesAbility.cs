using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBluesAbility : MonoBehaviour
{
    [SerializeField] private GameObject _clones;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))                //Reset Script
        {
            _clones.SetActive(false);
            Debug.Log("position reset (2)");            //Logs In Console
        }
    }
}
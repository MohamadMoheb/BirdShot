using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBluesAbility : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Vector2 spawnPosition;
    [SerializeField] private bool random;
    
    public bool _activated;

    // Start is called before the first frame update
    /*public void OnSpawnPrefab()
    {
        if(random)
        {
            float x = Random.Range(-8,8);
            float y = Random.Range(-4,4);
            Instantiate(prefab, new Vector2(x, y), Quaternion.identity);
        }
        else
        {
            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
    }
*/
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && GetComponent<Rigidbody2D>().velocity.magnitude > 2 && _activated == false)
        {
            _activated = true;
            Debug.Log("Ability Activated");

            float x = Random.Range(-8,8);
            float y = Random.Range(-4,4);
            Instantiate(prefab, new Vector2(x, y), Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            _activated = false;
        }
    }
}
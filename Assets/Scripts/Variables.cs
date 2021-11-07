using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    [SerializeField] private Vector2 _blueVector;
    [SerializeField] private Vector2 _jayVector;
    [SerializeField] private Vector2 _jakeVector;
    [SerializeField] private Vector2 _jimVector;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _blueVector = Blue._bluevelocity;
        _jayVector = Jay._jayvelocity;
        _jakeVector = Jake._jakevelocity;
        _jimVector = Jim._jimvelocity;
    }
}
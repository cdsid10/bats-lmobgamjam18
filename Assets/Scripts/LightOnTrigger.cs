using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnTrigger : MonoBehaviour
{
    [SerializeField] private GameObject candleLight;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        candleLight.SetActive(true);
    }
}

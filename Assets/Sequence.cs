using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequence : MonoBehaviour
{
    private LightSequence _lightSequence;
    
    [SerializeField] private GameObject[] lightSequencer;
    [SerializeField] private GameObject teleport;
    
    // Start is called before the first frame update
    void Start()
    {
        _lightSequence = FindObjectOfType<LightSequence>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (lightSequencer[0].GetComponent<LightSequence>().lights[1].activeInHierarchy
        && lightSequencer[1].GetComponent<LightSequence>().lights[2].activeInHierarchy
        && lightSequencer[2].GetComponent<LightSequence>().lights[3].activeInHierarchy
        && lightSequencer[3].GetComponent<LightSequence>().lights[0].activeInHierarchy)
        {
            teleport.SetActive(true);
        }
            
        
    }
}

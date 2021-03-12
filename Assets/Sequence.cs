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
        if (lightSequencer[3].gameObject.GetComponent<LightSequence>().currentLight == 4 || lightSequencer[3].gameObject.GetComponent<LightSequence>().currentLight == 0 && 
            lightSequencer[0].gameObject.GetComponent<LightSequence>().currentLight == 1 &&
            lightSequencer[1].gameObject.GetComponent<LightSequence>().currentLight == 2 &&
            lightSequencer[2].gameObject.GetComponent<LightSequence>().currentLight == 3)
        {
            teleport.SetActive(true);
        }
        else
        {
            return;
        }
        
    }
}

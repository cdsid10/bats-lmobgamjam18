using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class White : MonoBehaviour
{
    [SerializeField] private GameObject whiteLight;
    public bool canInteract;
    [SerializeField] private GameObject arrowUi;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (canInteract)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(SequenceWhite());
            }
            
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        whiteLight.SetActive(false);
        canInteract = true;
        arrowUi.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        whiteLight.SetActive(true);
        canInteract = false;
        arrowUi.SetActive( false);
    }

    IEnumerator SequenceWhite()
    {
        yield return new WaitForSeconds(1f);
        whiteLight.SetActive(true);
        yield return new WaitForSeconds(0.15f);
        whiteLight.SetActive(false);
        
        yield return new WaitForSeconds(0.5f);
        whiteLight.SetActive(true);
        yield return new WaitForSeconds(0.15f);
        whiteLight.SetActive(false);
        
        yield return new WaitForSeconds(0.5f);
        whiteLight.SetActive(true);
        yield return new WaitForSeconds(0.15f);
        whiteLight.SetActive(false);
        
        yield return new WaitForSeconds(0.5f);
        whiteLight.SetActive(true);
        yield return new WaitForSeconds(0.15f);
        whiteLight.SetActive(false);
        
        yield return new WaitForSeconds(1f);
    }
}

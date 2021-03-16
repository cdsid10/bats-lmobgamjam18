using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSequence : MonoBehaviour
{
    private AudioManager _audioManager;
    private PlayerDisguise _playerDisguise;
    
    [SerializeField] public GameObject[] lights;
    public int currentLight;
    private bool canInteract;
    
    // Start is called before the first frame update
    void Start()
    {
        _playerDisguise = FindObjectOfType<PlayerDisguise>();
        _audioManager = FindObjectOfType<AudioManager>();
        currentLight = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (currentLight > 4)
        {
            currentLight = 1;
        }
        

        if (canInteract && _playerDisguise.hasDisguise)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                _audioManager.PlayLightChange();
                currentLight++;
                
            }
            
            if (Input.GetKeyUp(KeyCode.E))
            {
                
                if (currentLight == 1)
                {
                    lights[1].SetActive(true);
                    lights[0].SetActive(false);
                }
                else if (currentLight == 2)
                {
                    lights[2].SetActive(true);
                    lights[1].SetActive(false);
                }
                else if (currentLight == 3)
                {
                    lights[3].SetActive(true);
                    lights[2].SetActive(false);
                }
                else if (currentLight >= 4)
                {
                    lights[0].SetActive(true);
                    lights[3].SetActive(false);
                }
                
                
            }
            
        }

        
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        canInteract = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        canInteract = false;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSesame : MonoBehaviour
{
    private PlayerDisguise _playerDisguise;
    private AudioManager _audioManager;

    [SerializeField] private GameObject gate;
    
    // Start is called before the first frame update
    void Start()
    {
        _playerDisguise = FindObjectOfType<PlayerDisguise>();
        _audioManager = FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && _playerDisguise.hasDisguise)
        {
            StartCoroutine(DoorOpen());
        }
    }

    IEnumerator DoorOpen()
    {
        _audioManager.PlayGateOpen();
        yield return new WaitForSeconds(0.5f);
        gate.SetActive(false);
        _playerDisguise.canRevert = true;
        yield return new WaitForSeconds(1f);
    }
}

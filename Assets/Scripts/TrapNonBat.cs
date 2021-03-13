using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapNonBat : MonoBehaviour
{
    private PlayerDisguise _playerDisguise;

    [SerializeField] private Animator _animator;
    private AudioManager _audioManager;

    [SerializeField] private int scenes;
    
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
            StartCoroutine(RestartNextLevel());
        }
        else
        {
            return;
        }
    }
    
    IEnumerator RestartNextLevel()
    {
        _audioManager.PlayFail();
        _animator.SetTrigger("fade");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(scenes);
    }
}

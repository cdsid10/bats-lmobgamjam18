using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTele : MonoBehaviour
{
    private AudioManager _audioManager;
    [SerializeField] private Animator _animator;
    
    [SerializeField] private int scenes;
    // Start is called before the first frame update
    void Start()
    {
        _audioManager = FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(StartNextLevel());
        }
    }

    IEnumerator StartNextLevel()
    {
        _audioManager.PlayLevelComplete();
        _animator.SetTrigger("fade");
        yield return new WaitForSeconds(2.25f);
        SceneManager.LoadScene(scenes);
    }
    
}

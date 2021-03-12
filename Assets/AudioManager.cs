using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private PlayerDisguise _playerDisguise;
    
    [SerializeField] private AudioSource _audioSource;

    [SerializeField] private AudioClip levelComplete, wingsFlap;
    
    // Start is called before the first frame update
    void Start()
    {
        _playerDisguise = FindObjectOfType<PlayerDisguise>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerDisguise.hasDisguise == false)
        {
            
        }
    }

    public void PlayLevelComplete()
    {
        _audioSource.PlayOneShot(levelComplete);
    }
}

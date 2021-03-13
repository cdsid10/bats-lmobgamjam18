using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private PlayerDisguise _playerDisguise;
    
    [SerializeField] private AudioSource _audioSource;

    [SerializeField] private AudioClip levelComplete, gateOpen, disguise, fail;
    [SerializeField] private AudioClip[] lightChange;
    
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

    public void PlayGateOpen()
    {
        _audioSource.PlayOneShot(gateOpen);
    }

    public void PlayLightChange()
    {
        
        _audioSource.PlayOneShot(lightChange[Random.Range(0, lightChange.Length)]);
    }

    public void PlayDisguise()
    {
        _audioSource.PlayOneShot(disguise);
    }

    public void PlayFail()
    {
        _audioSource.PlayOneShot(fail);
    }
}

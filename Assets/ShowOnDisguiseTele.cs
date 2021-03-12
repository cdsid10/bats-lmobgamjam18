using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowOnDisguiseTele : MonoBehaviour
{
    private PlayerDisguise _playerDisguise;

    [SerializeField] private GameObject teleport;
    // Start is called before the first frame update
    void Start()
    {
        _playerDisguise = FindObjectOfType<PlayerDisguise>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerDisguise.hasDisguise)
        {
            teleport.SetActive(true);
        }
    }
}

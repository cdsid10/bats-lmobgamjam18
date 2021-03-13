using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDisguise : MonoBehaviour
{
    private AudioManager _audioManager;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Sprite[] sprites;
    
    public bool canDisguise;
    public bool hasDisguise = false;
    public bool canRevert = false;

    [SerializeField] private GameObject box, circle, bat, batL, batR, viking, arrowUi;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _audioManager = FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canDisguise && Input.GetKeyDown(KeyCode.Space))
        {
            hasDisguise = true;
            //_spriteRenderer.sprite = sprites[1];
            box.SetActive(true);
            circle.SetActive(false);
            bat.SetActive(false);
            batL.SetActive(false);
            batR.SetActive(false);
            viking.SetActive(true);
            _audioManager.PlayDisguise();

        }
        
        if (hasDisguise && Input.GetKeyDown(KeyCode.X) && canRevert)
        {
            hasDisguise = false;
            //_spriteRenderer.sprite = sprites[0];
            box.SetActive(false);
            circle.SetActive(true);
            bat.SetActive(true);
            batL.SetActive(true);
            batR.SetActive(true);
            viking.SetActive(false);
            canRevert = false;
            _audioManager.PlayDisguise();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            arrowUi.SetActive(true);
            canDisguise = true;
            if (hasDisguise)
            {
                canDisguise = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            arrowUi.SetActive(false);
            canDisguise = false;
        }
    }
}

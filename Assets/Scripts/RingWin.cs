using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RingWin : MonoBehaviour
{
    private AudioManager _audioManager;
    [SerializeField] private Animator _animator;

    private bool canInteract;

    [SerializeField] private GameObject arrow;
    
    // Start is called before the first frame update
    void Start()
    {
        _audioManager = FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canInteract)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(FinishLevel());
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canInteract = true;
            arrow.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canInteract = false;
            arrow.SetActive(false);
        }
    }

    IEnumerator FinishLevel()
    {
        _audioManager.PlayWin();
        _animator.SetTrigger("fade");
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(7);
    }
}

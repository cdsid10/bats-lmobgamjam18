using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    [SerializeField] private float timeRemaining = 1f;
    [SerializeField] private GameObject rKey;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                rKey.SetActive(true);
                if (timeRemaining <= 0)
                {
                    SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
                }
            }
            
        }
        else if (Input.GetKeyUp(KeyCode.R))
        {
            timeRemaining = 1f;
            rKey.SetActive(false);
        }
    }
}

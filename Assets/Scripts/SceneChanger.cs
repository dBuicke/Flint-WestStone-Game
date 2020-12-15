using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D Enter)
    {
        if(Enter.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(1);
        }
        
    }
}

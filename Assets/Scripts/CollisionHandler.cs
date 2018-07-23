using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour {

    [Tooltip("In seconds")][SerializeField] float loadLevelDelay = 1f;
    [Tooltip("Particle effects prefab on player")][SerializeField] GameObject deathFX;
    
    private void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
        deathFX.SetActive(true);
        Invoke("ReloadScene", loadLevelDelay);
    }

    private void StartDeathSequence()
    {
        SendMessage("OnPlayerDeath");

    }

    private void ReloadScene() //String referenced
    {
        SceneManager.LoadScene(1);
    }
}
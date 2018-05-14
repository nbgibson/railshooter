using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {

    public void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Use this for initialization
    void Start () {
        Invoke("LoadFirstScene", 2f); //Fire LoadFistScene after 2 seconds
	}
	
	void LoadFirstScene()
    {
        SceneManager.LoadScene(1); 
    }
}

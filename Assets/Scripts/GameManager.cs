using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; 

    public int vidas = 3;

    public int puntos = 0;


    void Awake()
    {
        
        //Si ya hay una instancia y noo soy yo me destruyo
        if(Instance != null  && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(this);
    }

    public void RestarVidas()
    {
        vidas--;
    }

    void Update()
    {
        
    }

    public void LoadScene(int scenebuildIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}

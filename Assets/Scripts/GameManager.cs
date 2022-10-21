using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            Destroy(this);
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
}

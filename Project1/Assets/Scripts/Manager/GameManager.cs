using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager _instance;
    public GUIManager _GUIManager;

    void Awake()
    {
        if (_instance == null)
            _instance = this;
        else if (_instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(_GUIManager);

        InitGame();
    }

    void InitGame()
    {

    }
}

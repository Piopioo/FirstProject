using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager _instance;
    public GUIManager _GUIManager;
    public GAMESTATE _gameState;

    public enum GAMESTATE
    {
        GUI,
        GAME,
        QUIT
    };

    void Awake()
    {
        _gameState = GAMESTATE.GUI;

        if (_instance == null)
            _instance = this;
        else if (_instance != this)
            Destroy(gameObject);

        Instantiate(_GUIManager);

        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(_GUIManager);

        InitGame();
    }

    void InitGame()
    {

    }
}

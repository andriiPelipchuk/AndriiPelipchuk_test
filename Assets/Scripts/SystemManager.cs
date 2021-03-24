using System;
using UnityEngine;

public enum Manager
{
    MainMenu,
    GamePlay,
    Loss
}
public class SystemManager : MonoBehaviour
{

    public Manager myManager;

    private void Awake()
    {
        myManager = Manager.MainMenu;
    }
}

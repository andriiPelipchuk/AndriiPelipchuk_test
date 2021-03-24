using UnityEngine;

public class PopUp : MonoBehaviour
{
    [SerializeField] private GameObject buttonStart;
    [SerializeField] private GameObject buttonRestart;
    [SerializeField] private GameObject buttonMenu;
    [SerializeField] private GameObject blackout;

    [SerializeField] private Ball _ballScr;
    [SerializeField] private Platform _platformScr;
    public SystemManager _sysManager;

    public void Update()
    {
        if(_sysManager.myManager == Manager.MainMenu)
        {
            buttonStart.SetActive(true);
            blackout.SetActive(true);

        }
        else if(_sysManager.myManager == Manager.Loss)
        {
            blackout.SetActive(true);
            buttonMenu.SetActive(true);
            buttonRestart.SetActive(true);
        }
    }
    public void ButtonMenu()
    {
        buttonMenu.SetActive(false);
        buttonRestart.SetActive(false);
        blackout.SetActive(false);
        _sysManager.myManager = Manager.MainMenu;
    }
    public void ButtonStart()
    {
        buttonStart.SetActive(false);
        blackout.SetActive(false);
        _sysManager.myManager = Manager.GamePlay;
        _platformScr.AlignPlatform();
        _ballScr.ActiveGravity();
        _ballScr.stopwatch = 0;
    }
    public void ButtonRestart()
    {
        buttonMenu.SetActive(false);
        buttonRestart.SetActive(false);
        blackout.SetActive(false);
        _sysManager.myManager = Manager.GamePlay;
        _platformScr.AlignPlatform();
        _ballScr.ActiveGravity();
        _ballScr.stopwatch = 0;
    }
}

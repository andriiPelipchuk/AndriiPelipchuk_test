using UnityEngine;

public class Joystic : MonoBehaviour
{
    [SerializeField] private RectTransform _stick;

    public Platform platform_Script;
    public SystemManager _sysManager;

    private Vector3 startPosition;


    private void Start()
    {
        startPosition = _stick.position;
    }
    private void Update()
    {
        if (_sysManager.myManager == Manager.GamePlay)
        {
            if (Input.GetMouseButton(0))
            {
                StickMovement();
            }
            else if (Input.GetMouseButtonUp(0))
            {
                _stick.position = startPosition;
                platform_Script.platformRotation = Vector3.zero;
            }
        }

    }
    private void StickMovement()
    {
        var touchPos = Input.mousePosition;
        var dir = touchPos - startPosition;

        if (dir.magnitude < 150)
        {
            _stick.position = touchPos;
            platform_Script.platformRotation = dir;
        }
    }
}

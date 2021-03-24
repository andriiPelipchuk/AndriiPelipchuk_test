using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Text time;
    [HideInInspector] public float stopwatch = 0;
    public SystemManager _sysManager;
    private Rigidbody _gravity ;


    private void Start()
    {
        _gravity = gameObject.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (_sysManager.myManager == Manager.GamePlay)
        {
            stopwatch += Time.deltaTime;
            time.text = stopwatch.ToString();
        }
    }

    public void ActiveGravity()
    {
        transform.position = new Vector3(0, 3, 1);
        _gravity.useGravity = true;
    }

    private void OnTriggerExit(Collider GameOver)
    {
        StartCoroutine(TimerTeleportBall());
        _sysManager.myManager = Manager.Loss;
    }
    IEnumerator TimerTeleportBall()
    {
        yield return new WaitForSeconds(1);
        _gravity.useGravity = false;
        _gravity.velocity = Vector3.zero;
        transform.position = new Vector3(0, -10, 1);
    }
}

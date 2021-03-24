using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private GameObject platform;

    public Vector3 platformRotation;

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            ConvertToRottation();
        }

    }

    private void ConvertToRottation()
    {
        platformRotation.z = platformRotation.x;
        platformRotation.x = platformRotation.y;
        platformRotation.y = 0;

        platformRotation.z /= 2;
        platformRotation.x /= 2;

        platform.transform.Rotate( new Vector3(platformRotation.x, 0 , platformRotation.z) * Time.deltaTime, Space.Self);

    }
    public void AlignPlatform()
    {
        platform.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}

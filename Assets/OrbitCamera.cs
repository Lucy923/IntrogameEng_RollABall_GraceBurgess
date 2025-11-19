using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
  
	public float rotMult = 4f;

    float yaw = 0f;
    float pitch = 0f;

    public float maxY = -65; // For some reason, the signs are strange.
    public float minY = 50;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        yaw += rotMult * Input.GetAxis("Mouse X");
        pitch -= rotMult * Input.GetAxis("Mouse Y");
        pitch = Mathf.Clamp(pitch, maxY, minY);
    }

}

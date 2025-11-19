using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player; //references player
    private Vector3 offset; //stores xyz

    public float rotMult = 4f; //multiply mouse input aka sensitivity 

    float yaw = 0f; //rotation 
    // if i want to move up and down bring back pitch 

    //public float maxY = -65; 
    //public float minY = 50; 

    // Start is called before the first frame update.
    void Start()
    {
        offset = transform.position - player.transform.position;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Rotate the camera based on mouse input
        Quaternion rotation = Quaternion.Euler(0f, yaw, 0f); 
        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform.position); 
    }

    private void Update()
    {
        yaw += rotMult * Input.GetAxis("Mouse X");
        //pitch -= rotMult * Input.GetAxis("Mouse Y");
        //pitch = Mathf.Clamp(pitch, maxY, minY); 
    }

}

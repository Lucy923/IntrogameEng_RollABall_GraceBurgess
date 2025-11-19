using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 10f; // Adjust for desired strength
    public Vector3 launchDirection = Vector3.up; // Default: straight up

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = Vector3.zero; // Reset current velocity for consistency
            rb.AddForce(launchDirection.normalized * jumpForce, ForceMode.VelocityChange);
        }
    }
}
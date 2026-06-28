using UnityEngine;
using UnityEngine.InputSystem;

public class Bird : MonoBehaviour
{
    [SerializeField] private float flapForce = 5f;
    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Bird script is alive. rb is: " + (rb == null ? "NULL" : "OK"));
    }

    void Update()
    {
        bool tapped = Mouse.current.leftButton.wasPressedThisFrame
                   || Keyboard.current.spaceKey.wasPressedThisFrame;

        if (tapped)
        {
            Debug.Log("FLAP detected!");
            rb.linearVelocity = Vector3.up * flapForce;
        }
    }
}
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.2f;
    public Vector3 offset = new Vector3(0f, 0f, -10f);

    void Start()
    {
        // Auto-assign target if not manually assigned
        if (target == null)
        {
            GameObject car = GameObject.FindWithTag("Player");
            if (car != null)
                target = car.transform;
        }
    }

    private void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
    }
}

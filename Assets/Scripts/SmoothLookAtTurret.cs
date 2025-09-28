using UnityEngine;

public class SmoothLookAtTurret : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform target;
    [Range(0.1f, 10f)]
    public float rotationSpeed = 5f;

    private void Update()
    {
        if (target == null) return;
        Vector3 directionToTarget = target.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(directionToTarget);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
    
}

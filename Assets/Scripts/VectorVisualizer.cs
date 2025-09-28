using UnityEngine;

public class VectorVisualizer : MonoBehaviour
{
public Transform target;
    private void OnDrawGizmos() {
        
    if (target == null) return;

    Gizmos.color = Color.blue;
    Gizmos.DrawRay (transform.position, transform.forward * 2f);

    Gizmos.color = Color.green;
    Gizmos.DrawRay (transform.position, transform.up * 2f);
    Vector3 directionToTarget = target.position - transform.position;

    Gizmos.color = Color.red;
    Gizmos.DrawRay (transform.position, directionToTarget);
    
    Vector3 normalizedDirection = directionToTarget.normalized;

    Gizmos.color = Color.yellow;
    Gizmos.DrawRay (transform.position + new Vector3(0, 0.1f, 0), normalizedDirection * 2f);
}
}

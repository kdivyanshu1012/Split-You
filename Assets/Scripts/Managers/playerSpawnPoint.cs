using UnityEngine;

public class PloneSpawnPoint : MonoBehaviour
{
    [SerializeField] private Color color = Color.green;
    [SerializeField] private float radius = 0.2f;

    void OnDrawGizmos()
    {
        Gizmos.color = color;
        Gizmos.DrawSphere(transform.position, radius);
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * 0.5f);
    }
}

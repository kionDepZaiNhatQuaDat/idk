using UnityEngine;

public class RegionCameraSwap : MonoBehaviour
{
    public Camera miniMapCamera;
    public float regionSize = 10f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(miniMapCamera != null)
            {
                Vector3 newPosition = transform.position;
                newPosition.z = miniMapCamera.transform.position.z;
                miniMapCamera.transform.position = newPosition;

                miniMapCamera.orthographicSize = regionSize;
            }
        }
    }
}

using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector3 offset; // Un desfase para que la cámara no esté exactamente encima

    // LateUpdate se ejecuta después de todos los Updates.
    // Es el mejor lugar para el código de cámara, para evitar "tirones" (judder).
    void LateUpdate()
    {
        if (playerTransform != null)
        {
            // La posición de la cámara será la del jugador más el desfase
            transform.position = playerTransform.position + offset;
        }
    }
}
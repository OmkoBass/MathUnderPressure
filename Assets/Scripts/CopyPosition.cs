using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    [SerializeField]
    Transform TransformTarget;

    [SerializeField]
    Vector3 CameraOffset;

    private void Start()
    {
        CameraOffset = transform.position - TransformTarget.transform.position;
    }

    private void LateUpdate()
    {
        Vector3 NewPosition = TransformTarget.transform.position + CameraOffset;
        transform.position = NewPosition;
    }
}

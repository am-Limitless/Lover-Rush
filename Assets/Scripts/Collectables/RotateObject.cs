using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotateSpeed = 1.0f;
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}

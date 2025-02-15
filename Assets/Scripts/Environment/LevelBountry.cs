using UnityEngine;

public class LevelBountry : MonoBehaviour
{
    public static float leftSide = -3.3f;
    public static float rightSide = 3.3f;
    public float internalLeft;
    public float internalRight;

    void Update()
    {
        internalLeft = leftSide; internalRight = rightSide;
    }
}

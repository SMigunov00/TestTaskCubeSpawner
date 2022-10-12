using UnityEngine;

public class ObjectMovementData
{
    private float _objectSpeed;
    private float _distance;

    public ObjectMovementData(float speed, float distance)
    {
        _objectSpeed = speed;
        _distance = distance;
    }

    public float ObjectSpeed => _objectSpeed;
    public float Distance => _distance;
}

using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    private ObjectMovementData _objectMoveData;
    private float _distance;

    public void ObjectMovementData(ObjectMovementData objectMoveData)
    {
        _objectMoveData = objectMoveData;
    }

    private void Update()
    {
        if (_distance >= _objectMoveData.Distance)
            Destroy(gameObject);

        Move();
    }

    private void Move()
    {
        var movementVector = transform.right * _objectMoveData.ObjectSpeed * Time.deltaTime;
        _distance += movementVector.magnitude;
        transform.Translate(movementVector);
    }
}

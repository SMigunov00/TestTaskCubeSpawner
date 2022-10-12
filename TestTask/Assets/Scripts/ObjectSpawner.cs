using System;
using System.Collections;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public event Action OnDataValue;

    [SerializeField] private ObjectSpawnData _objectSpawnData;
    private bool _isPossibleCreate;

    private void Awake()
    {
        _objectSpawnData = Instantiate(_objectSpawnData);
    }

    private void Start()
    {
        _isPossibleCreate = true;
        StartCoroutine(SpawnObjectTimer());
        OnDataValue?.Invoke();
    }


    private void SpawnObject()
    {
        var _objectInstance = Instantiate(_objectSpawnData.ObjectPrefab, transform.position, Quaternion.identity);
        var _speed = _objectSpawnData.ObjectInitializedSpeed;
        var _distance = _objectSpawnData.ObjectDistanceMove;
        _objectInstance.GetComponent<ObjectMovement>().ObjectMovementData(new ObjectMovementData(_speed, _distance));
    }

    public float TimeBetweenSpawnObject
    {
        get => _objectSpawnData.TimeBetweenSpawnObject;
        set
        {
            _objectSpawnData.TimeBetweenSpawnObject = value;
            OnDataValue?.Invoke();
        }
    }

    public float ObjectInitializedSpeed
    {
        get => _objectSpawnData.ObjectInitializedSpeed;
        set
        {
            if(value > 0)
                _objectSpawnData.ObjectInitializedSpeed = value;
            
            OnDataValue?.Invoke();
        }
    }

    public float ObjectDistanceMove
    {
        get => _objectSpawnData.ObjectDistanceMove;
        set
        {
            if(value > 0)
                _objectSpawnData.ObjectDistanceMove = value;
            
            OnDataValue?.Invoke();
        }
    }

    private IEnumerator SpawnObjectTimer()
    {
        while (_isPossibleCreate)
        {
            SpawnObject();
            yield return new WaitForSeconds(_objectSpawnData.TimeBetweenSpawnObject);
        }
        yield break;
    }
}

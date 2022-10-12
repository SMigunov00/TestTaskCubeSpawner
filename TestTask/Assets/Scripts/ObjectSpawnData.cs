using UnityEngine;

[CreateAssetMenu(menuName = "Spawner object/Object data")]
public class ObjectSpawnData : ScriptableObject
{
    [SerializeField] private GameObject _prefabObjectCreate;
    [SerializeField] private float _timeBetweenSpawnObject;
    [SerializeField] private float _objectInitializedSpeed;
    [SerializeField] private float _objectDistanceMove;

    public GameObject ObjectPrefab => _prefabObjectCreate;
    public float TimeBetweenSpawnObject { get => _timeBetweenSpawnObject; set => _timeBetweenSpawnObject = value; }
    public float ObjectInitializedSpeed { get => _objectInitializedSpeed; set => _objectInitializedSpeed = value; }
    public float ObjectDistanceMove { get => _objectDistanceMove; set => _objectDistanceMove = value; }
}

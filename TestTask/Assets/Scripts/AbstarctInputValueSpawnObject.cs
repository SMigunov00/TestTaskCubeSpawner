using UnityEngine;
using UnityEngine.UI;

public abstract class AbstarctInputValueSpawnObject : MonoBehaviour
{
    [SerializeField] protected ObjectSpawner _objectSpawn;
    [SerializeField] protected InputField _inputField;

    protected void Start()
    {
        _objectSpawn.OnDataValue += OnObjectSpawnDataValue;
        _inputField.onEndEdit.AddListener(OnInputValue);
    }

    protected virtual void OnInputValue(string inputValue)
    {
        var _valueParsed = float.TryParse(inputValue, out var floatValue);
        if (_valueParsed)
            OnInputValue(floatValue);
    }

    protected abstract void OnInputValue(float value);
    protected abstract void OnObjectSpawnDataValue();
}

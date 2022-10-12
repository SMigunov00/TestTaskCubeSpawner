public class DistanceSettingField : AbstarctInputValueSpawnObject
{
    protected override void OnObjectSpawnDataValue()
    {
        _inputField.text = _objectSpawn.ObjectDistanceMove.ToString();
    }

    protected override void OnInputValue(float value)
    {
        _objectSpawn.ObjectDistanceMove = value;
    }
}

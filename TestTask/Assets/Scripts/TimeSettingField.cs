public class TimeSettingField : AbstarctInputValueSpawnObject
{
    protected override void OnObjectSpawnDataValue()
    {
        _inputField.text = _objectSpawn.TimeBetweenSpawnObject.ToString();
    }

    protected override void OnInputValue(float value)
    {
        _objectSpawn.TimeBetweenSpawnObject = value;
    }
}

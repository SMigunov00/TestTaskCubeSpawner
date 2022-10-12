public class SpeedSettingField : AbstarctInputValueSpawnObject
{
    protected override void OnObjectSpawnDataValue()
    {
        _inputField.text = _objectSpawn.ObjectInitializedSpeed.ToString();
    }

    protected override void OnInputValue(float value)
    {
        _objectSpawn.ObjectInitializedSpeed = value;
    }
}

using System.Globalization;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _targetAmount;
    private int _bonus;
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public int GetTargetAmount()
    {
        return _targetAmount;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public ChecklistGoal(string name, string description, string points, string targetAmount, string bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _targetAmount = int.Parse(targetAmount);
        _bonus = int.Parse(bonus);
    }
    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _targetAmount;
    }
    public override string GetDetailsString()
    {

        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {GetName()}, {GetDescription()} -- Currently completed: {_amountCompleted} of {_targetAmount}";
    }
    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{GetName()},{GetDescription()},{GetPoints()},{_targetAmount},{_bonus},{_amountCompleted}";
    }
}
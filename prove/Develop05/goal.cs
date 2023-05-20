public abstract class Goal
{
    protected string _checkMark = " ";
    protected string _name;
    protected string _description;
    protected int _value;
    protected bool _iscompleted;


    public Goal(string name, string description, int value, bool iscompleted)
    {
        name = _name;
        description = _description;
        value = _value;
        _iscompleted = iscompleted;
    }

    public abstract void DisplayGoal();
    public abstract string StrimGoal();
    public abstract int completeGoal();

}
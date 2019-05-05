abstract class Pump
{
    protected bool success = true;
    public bool Success
    {
        get { return success; }
        set { success = value; }
    }

    public abstract bool SwitchOn();
}

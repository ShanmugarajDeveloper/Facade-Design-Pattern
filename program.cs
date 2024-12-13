// Subsystems

public interface ISubSystem
{
    public void Operation();
}
public class SubsystemA:ISubSystem
{
    public void Operation() => Console.WriteLine("SubsystemA: OperationA");
}

public class SubsystemB:ISubSystem
{
    public void Operation() => Console.WriteLine("SubsystemB: OperationB");
}

public class SubsystemC:ISubSystem
{
    public void Operation() => Console.WriteLine("SubsystemC: OperationC");
}

// Violated Facade
public class ComplexFacade
{
    private ISubSystem _subsystemA;
    private ISubSystem _subsystemB;
    private ISubSystem _subsystemC;
    public ComplexFacade()
    {
        _subsystemA = new SubsystemA();
        _subsystemB = new SubsystemB();
        _subsystemC = new SubsystemC();
    }

    public void PerformOperation()
    {
        _subsystemA.Operation();
        _subsystemB.Operation();
        _subsystemC.Operation();
    }

    
}
public class Client
{
    public static void Main(string[] args)
    {
        ComplexFacade facade = new ComplexFacade();
        facade.PerformOperation();
    }
}

using branches;
class Program
{
    public static void Main()
    {
        Console.WriteLine("This is a program creating hierarchical structure");
        Branch branch = BranchFactory.CreateBranch();
        int depth = branch.CalculateDepth(branch, 0);
        Console.WriteLine("Tree depth is {0}", depth);
    }
}
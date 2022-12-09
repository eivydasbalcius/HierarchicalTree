namespace branches
{
    internal class BranchFactory
    {
        public static Branch CreateBranch()
        {
            Console.WriteLine("Creating new branch");
            string? branchName = GetBranchName();
            
            Branch branch = new(branchName);

            while (true)
            {
                Console.WriteLine("Dose {0} have child branch? (yes/no)", branchName);
                string? addChild = Console.ReadLine();
                if (addChild == "yes")
                {

                    branch.AddChildBranch(CreateBranch());
                }
                else if (addChild != "no" && addChild != "yes")
                {

                    Console.WriteLine("Ops, something went wrong. Please enter correct phrase (yes/no)");
                }
                else
                {
                    break;
                }
            }
            return branch;
        }

        private static string GetBranchName()
        {
            string? branchName = "";
            while (String.IsNullOrEmpty(branchName))
            {
                Console.WriteLine("Enter branch name: ");
                branchName = Console.ReadLine();
                if (!String.IsNullOrEmpty(branchName))
                {
                    break;
                }
            }
            return branchName;
        }
    }
}

namespace branches
{
    internal class Branch
    {
        public List<Branch> Branches { get; set; }
        public string Name { get; set; }

        public Branch(string name) { 
            Name = name;    
            Branches= new List<Branch>();
        }

        public void AddChildBranch(Branch branch)
        {
            Branches.Add(branch);
        }

        public int CalculateDepth(Branch parent, int depth)
        {
            int result = depth;
            foreach (var branch in parent.Branches)
            {
                result = Math.Max(result, CalculateDepth(branch, depth + 1));
            }

            return result;
        }
    }
}

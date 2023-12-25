namespace BikeTreeApp
{
    public class Node
    {
        //part is pedal,wheel,seat
        public string PartName { get; }
        //available inventory of this part
        public int Inventory { get; set; }
        public Node[] Children { get; set; }

        public Node(string partName, int inventory)
        {
            PartName = partName;
            Inventory = inventory;
        }

        public int CalculateMaxBundles(int bundlesPerNode)
        {
            // If the part is a leaf node, return the available inventory divided by the bundles per node
            if (Children == null || Children.Length == 0)
            {
                return Inventory / bundlesPerNode;
            }

            // If the part has children, calculate the maximum bundles based on each child
            int maxBundles = int.MaxValue;
            foreach (var child in Children)
            {
                int bundlesFromChild = child.CalculateMaxBundles(bundlesPerNode);
                maxBundles = Math.Min(maxBundles, bundlesFromChild);
            }

            return maxBundles;
        }
    }

}

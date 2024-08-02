namespace InheritanceMiniProject
{
    internal interface IRentable :IInventoryItem
    {
        void Rent();
        void ReturnRental();
    }
}
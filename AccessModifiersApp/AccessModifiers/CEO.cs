using DemoLibrary;

// You have to be careful with modifiers if you want to keep access to user information secure.
namespace AccessModifiers
{
    public class CEO : Manager
    {
        public void GetConnectionInfo()
        {
            ModifiedDataAccess data = new ModifiedDataAccess();
            data.GetUnsecureConnectionInfo();
            formerLastName = "test";
        }
    }
}

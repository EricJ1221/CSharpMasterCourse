using DemoLibrary;

// You have to be careful with modifiers if you want to keep access to user information secure.
namespace AccessModifiers
{
    public class ModifiedDataAccess : DataAccess
    {
        public void GetUnsecureConnectionInfo()
        {
            GetConnectionString();
        }
    }
}

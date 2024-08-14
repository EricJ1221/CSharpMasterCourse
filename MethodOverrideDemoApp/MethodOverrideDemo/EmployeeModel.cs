namespace MethodOverrideDemo
{
    public class EmployeeModel : PersonModel 
    { 
        public decimal HourlyRate { get; set; }

        public virtual decimal GetPaycheckAmount(int hoursWorked) // You have to add virtual so it can be overriden
        {
            return HourlyRate * hoursWorked;
        }
    }
}

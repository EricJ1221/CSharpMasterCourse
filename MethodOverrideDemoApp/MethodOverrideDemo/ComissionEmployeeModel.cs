namespace MethodOverrideDemo
{
    public class ComissionEmployeeModel : EmployeeModel
    {
        public decimal ComissionAmount { get; set; }

        public override decimal GetPaycheckAmount(int hoursWorked)
        {

            decimal initialPay = base.GetPaycheckAmount(hoursWorked);

            return initialPay + ComissionAmount;
        }
    }
}

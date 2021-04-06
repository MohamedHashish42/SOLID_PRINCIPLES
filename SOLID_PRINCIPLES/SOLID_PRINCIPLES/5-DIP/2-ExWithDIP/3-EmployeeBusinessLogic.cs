namespace SOLID_PRINCIPLES._5_DIP._2_ExWithDIP
{
    class EmployeeBusinessLogic
    {
        //Depending on absraction
        IEmployeeDataAccess _EmployeeDataAccess;

        public EmployeeBusinessLogic()
        {
            _EmployeeDataAccess = new EmployeeDataAccess();
        }
        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccess.GetEmployeeDetails(id);
        }
    }
}

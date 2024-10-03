namespace ClinicSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var doctor = new Doctor();
            doctor.Id = 1;
            doctor.Name = "Test";
            doctor.Department = Department.GeneralSurgery;
            doctor.FullAuth = true;
            doctor.Shift = Shift.Morning;
            doctor.IsOnline = true;

            var assistant = new Assistant();
            assistant.Id = 1;
            assistant.Name = "assisstant1";
            assistant.IsOnline = true;
           
            doctor.AddAssisstant(assistant);
            
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "Ahmed";
            customer.Gender = Gender.Male;
            customer.Address = "Cairo";
            customer.Age = 20;
            assistant.AddNewCustomer(customer);
            var app = new Appoinment();
            app.Assistant = assistant;
            app.Customer = customer;
            app.Doctor = doctor;
            app.Status = false;
            app.Date = DateOnly.FromDateTime(DateTime.Now);

            assistant.AddAppoinment(DateOnly.FromDateTime(DateTime.Now), TimeOnly.FromDateTime(DateTime.Now), customer, doctor);

            
        }
    }
}

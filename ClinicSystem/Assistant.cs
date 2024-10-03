namespace ClinicSystem
{
    public class Assistant : Account
    {
        public bool FullAuth { get; set; } = false;

        public List<Customer> WaitingList()
        {
            return DataBase.CustomersList.Select(c => c.Value).ToList();
        }

        public void AddNewCustomer(Customer customer)
        {
            if (DataBase.CustomersList[customer.Id] is null)
            {
                DataBase.CustomersList[customer.Id] = customer;
                Console.WriteLine("Customer Added!");
            }
            Console.WriteLine("Coustomer didn't added!");
        }

        public bool AddToWaitingList(Customer customer)
        {
            AddNewCustomer(customer);
            WaitingList();
            return true;    
        }

        public void AddAppoinment(DateOnly date, TimeOnly time, Customer customer, Doctor doctor)
        {
            if(customer is not null && doctor is not null)
            {
                var appoinment = new Appoinment();
                appoinment.Date = date;
                appoinment.Time = time;
                appoinment.Customer = customer;
                appoinment.Doctor = doctor;
                
                DataBase.AppoinmentsList.Add($"{appoinment.Date},{appoinment.Time}", appoinment);
            }
        }

        public void DeleteAppoinment(Appoinment appoinment)
        =>  DataBase.DeleteAppoinment(appoinment);
       

        public void ChangeApoinment(Appoinment appoinment)
            => DataBase.UpdateAppoinment(appoinment);  
    }
}
using OOP2;
//SOLID
//Gerçek Müşteri

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.CustomerNumber = "12345";
customer1.Name = "Ahmet";
customer1.LastName = "Özkan";
customer1.TcNumber = "22222222222";

//Tüzel Müşteri - Kodlama.io
CoorporateCustomer customer2 = new CoorporateCustomer();
customer2.Id = 2;
customer2.CustomerNumber = "12346";
customer2.CompanyName = "Kodlama.io";
customer2.TaxNumber = "22222222222";

Customer customer3 = new IndividualCustomer(); //Reference number
Customer customer4 = new CoorporateCustomer();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);
customerManager.Add(customer3);
customerManager.Add(customer4);


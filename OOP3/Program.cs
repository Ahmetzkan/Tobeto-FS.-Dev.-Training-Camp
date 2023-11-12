using OOP3;

//İnterface onu implemente eden classın ismini tutabilir.
//Liste şeklinde aşağıdakilerden birini seçtiğimizi düşünelim;

ICreditManager consumerCredit = new ConsumerCredit();
ICreditManager vehicleCredit = new VehicleCredit();
ICreditManager mortgageManager = new MortgageCreditManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

//consumerCrediti seçerek soyutlama yaptık.
ApplicationManager applicationManager = new ApplicationManager();

List<ILoggerService> logger = new List<ILoggerService>()
{new DatabaseLoggerService(),new SmsLoggerService()};

//Başvuru yap ve logla.
applicationManager.DoApplication(new TradesmanCreditManager(), logger);


List<ICreditManager> credits = new List<ICreditManager>() 
{consumerCredit,vehicleCredit,mortgageManager};
//applicationManager.DoCreditPreliminaryInformation(credits);


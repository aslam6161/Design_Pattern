using DesignPattern.AbstractFactory;
using DesignPattern.FactoryMethod;
using DesignPattern.FluentInterface;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Factory Method 
            Console.WriteLine("Factory Method\n");
            var converterService = new DocumentConverterService();

            converterService.ExportDocument(new PdfConverterFactory(), "source.docx", "output.pdf");
            converterService.ExportDocument(new DocxConverterFactory(), "source.pdf", "output.docx");

            #endregion
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------");

            #region Abstract Factory
            Console.WriteLine("Abstract Factory\n");
            IVehicleFactory regularVehicleFactory = new RegularVehicleFactory();

            IBike regularBike = regularVehicleFactory.CreateBike();
            regularBike.GetDetails();

            ICar regularCar = regularVehicleFactory.CreateCar();
            regularCar.GetDetails();


            IVehicleFactory sportsVehicleFactory = new SportsVehicleFactory();

            IBike sportBike = sportsVehicleFactory.CreateBike();
            sportBike.GetDetails();

            ICar sportsCar = sportsVehicleFactory.CreateCar();
            sportsCar.GetDetails();

            #endregion
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------");

            #region Fluent Interface
            Console.WriteLine("Fluent Interface\n");
            var customer = new FluentInterface.Customer { FirstName = "Rohan", LastName = "Ahmad" };
            //way 1
            var mapper = MapperConfig.InitializeAutomapper();
            var custmerDTO1 = mapper.Map<CustomerDTO>(customer);
            Console.WriteLine(custmerDTO1.FullName);

            //way 2
            var customerDTO2 = mapper.Map<Customer, CustomerDTO>(customer);
            Console.WriteLine(customerDTO2.FullName);
            #endregion

            IComparable<int> val = 12;

            GenericClass<Test> genericClass = new GenericClass<Test>();
            var d=genericClass.genericMethod(new Test() { Id=10});
            genericClass.GenericProperty = d;

            Console.WriteLine($"{d.Id} {genericClass.GenericProperty.Id}");

        }
    }

    public class Test
    {
        public int Id { get; set; }
        public Test()
        {

        }
    }

    public class GenericClass<T> where T: new()
    {
        private T genericField;

        public T genericMethod(T val)
        {
            this.genericField = val;
            return this.genericField;
        }

        public T GenericProperty { get; set; }
    }
}

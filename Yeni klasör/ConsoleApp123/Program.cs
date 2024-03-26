namespace task_1
{

    internal class Program
    {

        static void Main(string[] args)
        {
            {

            }

        }


        class Vehicle
        {
            public string brand;
            public string model;
            public double mile;

            public Vehicle(string brand, string model)
            {
                this.brand = brand;
                this.model = model;
                
            }
            public void ShowFullInfo()
            {
                Console.WriteLine($"brand:{brand}, model:{model}");
            }
        }



         
        class car : Vehicle
        {
            public int doorsNum;

            public car(string brand, string model) :base(brand, model)
            {


            }









        }
        class MotorCycle : Vehicle
        {
            public int WheelNum;

            public MotorCycle(string brand, string model) : base(brand, model)
            {


            }
        }


    }

}
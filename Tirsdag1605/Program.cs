namespace Tirsdag1605
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            //database.createHardcoded();
            //string insert = "insert into animal values";
            //database.create(insert + "('black','','Mr Black','chill',123)");
            //database.create($"{insert}('{animal1.Color}','','{animal1.FirstName}','{animal1.LastName}',{animal1.Age})");

            Animal animal1 = new Animal() { Age=33, Color="Yellow", Name="", FirstName="Spongebob", LastName="Squarepants" };
            Animal animal2 = new Animal() { Age = 133, Color = "Purple", Name = "", FirstName = "Rich", LastName = "Manson" };
            Animal animal3 = new Animal() { Age = 20, Color = "Blue", Name = "", FirstName = "Jesper", LastName = "Sonnes" };

            Car car1 = new Car() { Age = 10, Color = "Green", Name = "", Model = "A6", Maker = "Audi" };
            Car car2 = new Car() { Age = 22, Color = "Red", Name = "", Model = "F1", Maker = "McLaren" };
            Car car3 = new Car() { Age = 2, Color = "Black", Name = "", Model = "AMG One", Maker = "Mercedes" };

            //animal3.create();
            //animal1.create();
            //animal2.create();

            ////animal2.delete(10);

            //Animal.ReadAll();

            //Animal.Read(13);

            Animal.NameJumble(14);



            int[] intArr = new int[3];
            intArr[1] = 1;
            intArr[2] = 2;
            intArr[3] = 3;

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Console.WriteLine(intArr[i]);
                }
                catch (Exception e)
                {

                    Console.WriteLine("Array size execced:" + e);
                }
            }

            int a = 5;

            try
            {
                int b = a / 0;
            }
            catch (Exception e)
            {

                Console.WriteLine("Cannot divide with 0:" + e);
            }


            Animal animal4 = null;

            try
            {
                animal4.create();
            }
            catch (Exception e)
            {

                Console.WriteLine("Animal has no value and cannot be created:" + e);
            }




        }

    }
}
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

            //animal3.create();
            //animal1.create();
            //animal2.create();

            ////animal2.delete(10);

            //Animal.ReadAll();

            //Animal.Read(13);

            Animal.NameJumble(14);
        }

    }
}
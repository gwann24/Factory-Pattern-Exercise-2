namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string uDBType;
            Console.WriteLine("Please enter the database you wish to use (List, SQL, or Mongo:");
            uDBType = Console.ReadLine();
            IDataAccess db1 = DataAccessFactory.GetDataAccessType(uDBType);
            var nProducts = db1.LoadData();
            db1.SaveData();
        }
    }
}

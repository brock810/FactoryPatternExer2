namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What database would you like to you use");
            string databaseType = Console.ReadLine();

            IDataAccess dataAccess = DataAccessFactory.GetDataAccessType( databaseType );

            dataAccess.LoadData();
            dataAccess.SaveData();

            Console.WriteLine("press any key to exit");
            
            }
        }
    }


using System.Data;
using static JSON_Test.AttributeTest;
using System;

namespace JSON_Test
{
    [Serializable]
    public class Database
    {
        string tableName;
        DataTable dt;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(AttributeTest);
            Attribute[] attributes = Attribute.GetCustomAttributes(type);

            foreach(var attr in attributes)
            {
                History history = attr as History;

                if(history != null)
                {
                    Console.WriteLine($"Version: {history.Version}, Name: {history.Name}, ChangeValues : {history.ChangeValue}");
                }
            }

            AttributeTest at = new AttributeTest();


            Json_Practice jp = new Json_Practice();

            jp.Example();
        }
    }
}

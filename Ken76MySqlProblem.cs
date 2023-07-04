using MySql.Data.MySqlClient;

// https://forum.codewithmosh.com/t/problem-with-string-array/21261
class Ken76MySqlProblem
{
    public static void Method(string connString, int idStatus)
    {
        string[] values = new string[0];
        int countValues = 0;


        using (var connection = new MySqlConnection(connString))
        {
            connection.Open();
            string query = "SELECT * from showvalues WHERE idstatus = '" + idStatus + "'";

            using (var command2 = new MySqlCommand(query, connection))
            {
                using (var reader2 = command2.ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        string result = reader2.GetString("textinfo");
                        // listBoxMeasurement.Items.Add(reader2.GetString("textinfo"));
                        Array.Resize(ref values, countValues + 1);
                        values[countValues] = reader2.GetString("textinfo");
                        countValues++;
                        System.Console.WriteLine($"{countValues} => {result}");
                    }
                    countValues = 0;
                    connection.Close();
                }
            }
        }

        System.Console.WriteLine($"\n\n=====\nIterating Array\n=====\n");
        Array.ForEach(values, (item) =>
        {
            System.Console.WriteLine($"Item => {item}");
        });
    }
}
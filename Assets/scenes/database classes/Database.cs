using UnityEngine;
using Mono.Data.Sqlite;

public class Database : MonoBehaviour
{
    private void Start()
    {
        var conn = string.Format("URI=file:${0}/Plugins/Users.s3db", Application.dataPath);
        var connection = new SqliteConnection(conn);

        connection.Open();

        using (var command = new SqliteCommand(@"SELECT id, Voornaam, Achternaam, Klas FROM Usersinfo"))
        {
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                var voorNaam = reader.GetString(1);
                var achterNaam = reader.GetString(2);
                var klas = reader.GetInt32(3);
                Debug.Log("value = " + id + "Voornaam = " + voorNaam + "  achternaam = " + achterNaam + "  klas = " +
                          klas);
            }

            reader.Close();
        }

        connection.Close();
    }
}
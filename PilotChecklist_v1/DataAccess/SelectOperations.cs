using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using PilotChecklist.Classes;

namespace PilotChecklist_v1.DataAccess
{
    internal class SelectOperations
    {
        DatabaseOperations dbOps = new DatabaseOperations();

        public List<Pilot> SelectPilots()
        {
            List<Pilot> pilots = new List<Pilot>();

            try
            {
                using (SqlConnection connection = new SqlConnection(dbOps.ConnectionString()))
                {
                    connection.Open();

                    string query = "SELECT * FROM Pilot";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Pilot pilot = new Pilot
                                    {
                                        Id = Convert.ToInt32(reader["Pilot_ID"]),
                                        Username = reader["Username"].ToString(),
                                        Password = reader["Password"].ToString(),
                                        Name = reader["Pilot_Name"].ToString(),
                                        Surname = reader["Pilot_Surname"].ToString(),
                                        FlightId = Convert.ToInt32(reader["Flight_ID"])
                                    };

                                    pilots.Add(pilot);
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception e)
            {
                App.Current.MainPage.DisplayAlert("Pilot Retrieval Error", e.Message, "OK");
                Console.WriteLine($"ERROR MESSAGE -> {e.Message}");
            }

            Console.WriteLine($"Pilot count: {pilots.Count}");
            return pilots;
        }

        public List<Flight> SelectFlight_ById(int flight_id)
        {
            List<Flight> flights = new List<Flight>();

            try
            {
                using(SqlConnection connection = new SqlConnection( dbOps.ConnectionString()))
                {
                    connection.Open();

                    string query = "SELECT * FROM Flight WHERE Flight_ID=@FlightID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FlightID", flight_id);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Flight flight = new Flight
                                    {
                                        Id = Convert.ToInt32(reader["Flight_ID"]),
                                        ChecklistId = Convert.ToInt32(reader["Checklist_ID"]),
                                        FlightName = reader["Flight_Name"].ToString(),
                                        DestinationFrom = reader["Destination_From"].ToString(),
                                        DestinationTo = reader["Destination_To"].ToString(),
                                        DepartureTime = reader["Departure_Time"].ToString(),
                                        ArrivalTime = reader["Estimated_Arrival"].ToString()
                                    };

                                    flights.Add(flight);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                App.Current.MainPage.DisplayAlert("Flight Retrieval Error:", e.Message, "OK");
                Console.WriteLine($"ERROR MESSAGE -> {e.Message}");
            }

            Console.WriteLine($"Flight count: {flights.Count}");
            return flights;
        }

        public List<Checklist> SelectChecklist_ById(int checklist_id)
        {
            List<Checklist> checklists = new List<Checklist>();

            try
            {
                using (SqlConnection connection = new SqlConnection(dbOps.ConnectionString()))
                {
                    connection.Open();

                    string query = $"SELECT * FROM Checklist WHERE Checklist_ID={checklist_id}";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Checklist checklist = new Checklist
                                    {
                                        Id = Convert.ToInt32(reader["Flight_ID"]),
                                        IsCompleted = Convert.ToBoolean(reader["isChecked"]),
                                        Progress = reader["Flight_Name"].ToString(),
                                        Timestamp = Convert.ToDateTime(reader["SSMA_TimeStamp"])
                                    };
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                App.Current.MainPage.DisplayAlert("Checklist Retrieval Error:", e.Message, "OK");
                Console.WriteLine($"ERROR MESSAGE -> {e.Message}");
            }

            Console.WriteLine($"Checklist count: {checklists.Count}");
            return checklists;
        }
    }
}

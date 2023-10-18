using PilotChecklist.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PilotChecklist_v1.DataAccess
{
    class UpdateOperations
    {
        DatabaseOperations dbOps = new DatabaseOperations();

        public void Update_Questions(List<Question> questions)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(dbOps.ConnectionString()))
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            foreach (var question in questions)
                            {
                                string query = "UPDATE Question SET Question = @Question, isChecked = @IsChecked WHERE Question_ID = @QuestionId";

                                using (SqlCommand command = new SqlCommand(query, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@Question", question.Item);
                                    command.Parameters.AddWithValue("@IsChecked", question.IsChecked);
                                    command.Parameters.AddWithValue("@QuestionId", question.Id);

                                    command.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit(); // All updates were successful, commit the transaction
                            App.Current.MainPage.DisplayAlert("Success", "Checklist saved!", "OK");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback(); // An error occurred, roll back the transaction
                            App.Current.MainPage.DisplayAlert("Error Saving Checklist:", ex.Message, "OK");

                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR MESSAGE -> {e.Message}");
            }
        }

        public void Update_Checklist(int id, bool value)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(dbOps.ConnectionString()))
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string query = "UPDATE Checklist SET isChecked = @IsChecked WHERE Checklist_ID = @ID";

                            using (SqlCommand command = new SqlCommand(query, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@ID", id);
                                command.Parameters.AddWithValue("@IsChecked", value);

                                command.ExecuteNonQuery();
                            }

                            transaction.Commit(); // All updates were successful, commit the transaction
                            Console.WriteLine($"Checklist Updated | value =  {value}");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback(); // An error occurred, roll back the transaction
                            Console.WriteLine($"Error Completing Checklist: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR MESSAGE -> {e.Message}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Npgsql;
using StockChecker.Models;

namespace StockChecker
{
    class DatabaseContext
    {
        private readonly string _signal;
        public DatabaseContext(string signal)
        {
            _signal = signal;
        }
        public void BulkUpsertVesselSignalData(List<VesselSignalData> data)
        {
            using (var connection = new NpgsqlConnection("User ID=postgres;Password=postgres;Host=database;Port=5432;Database=test;"))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    using (var cmd = new NpgsqlCommand("INSERT INTO vesselsignaldata (vesselimo, signal, datetime, value) Values(@vesselimo, @signal, @datetime, @value)", connection))
                    {
                        cmd.Parameters.AddWithValue("vesselimo", 12345678);
                        cmd.Parameters.AddWithValue("signal", "dummy_signal");
                        cmd.Parameters.AddWithValue("datetime", DateTime.UtcNow);
                        cmd.Parameters.AddWithValue("value", 1.2345678);
                        cmd.ExecuteNonQuery();
                    }
                    // Delete based on input

                    // Insert input

                    // Commit the transaction
                    transaction.Commit();
                }
            }
        }

    }
}
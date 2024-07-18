using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows;

namespace UIL_OPAL
{
    public class SqlLite
    {
        private static SqlLite _instance;
        private static readonly object _lock = new object();
        private SQLiteConnection _connection;
        private readonly string ConnectionString = Global.pathSqlite;

        private SqlLite()
        {
            try
            {
                string dbFilePath = ConnectionString.Split('=')[1].Trim();

                string directoryPath = Path.GetDirectoryName(dbFilePath);

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(dbFilePath));
                }

                if (!File.Exists(dbFilePath))
                {
                    SQLiteConnection.CreateFile(dbFilePath);
                }

                _connection = new SQLiteConnection(ConnectionString);
                _connection.Open();

                using (var command = new SQLiteCommand("PRAGMA cache_size = -20000;", _connection))
                {
                    command.ExecuteNonQuery();
                }

                using (var command = new SQLiteCommand("PRAGMA journal_mode = WAL;", _connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Global.ShowError($"Error can not create file database, error: {ex.Message}");
            }
        }

        public static SqlLite Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SqlLite();
                    }
                    return _instance;
                }
            }
        }

        public void CreateTable()
        {
            try
            {
                string createTableQuery = @"CREATE TABLE IF NOT EXISTS qrcodes (qr_code TEXT, content TEXT, created_at TEXT DEFAULT CURRENT_TIMESTAMP);";

                string createIndexQrCode = @"CREATE INDEX IF NOT EXISTS idx_qrcode ON qrcodes (qr_code);";

                string createIndexCreatedAt = @"CREATE INDEX IF NOT EXISTS idx_created_at ON qrcodes (created_at);";

                using (var command = new SQLiteCommand(createTableQuery, _connection))
                {
                    command.ExecuteNonQuery();
                }

                using (var command = new SQLiteCommand(createIndexQrCode, _connection))
                {
                    command.ExecuteNonQuery();
                }

                using (var command = new SQLiteCommand(createIndexCreatedAt, _connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Global.WriteLog($"Error can not create table, index - error: {ex.Message}");
                Global.ShowError($"Error can not create table, index - error: {ex.Message}");
            }
        }

        public void Insert(string qrCode, string content, string createdAt)
        {
            try
            {
                string insertQuery = "INSERT INTO qrcodes (qr_code, content, created_at) VALUES (@qrCode, @content, @createdAt);";

                using (var transaction = _connection.BeginTransaction())
                {
                    using (var command = new SQLiteCommand(insertQuery, _connection))
                    {
                        command.Parameters.AddWithValue("@qrCode", qrCode);
                        command.Parameters.AddWithValue("@content", content);
                        command.Parameters.AddWithValue("@createdAt", createdAt);
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                Global.WriteLog($"Error can not insert into table, error: {ex.Message}");
            }
        }

        public List<ResultSearch> GetResultSearch(string qrCode)
        {
            List<ResultSearch> results = new List<ResultSearch>();

            try
            {
                string cmd = @"SELECT * FROM qrcodes WHERE qr_code = @qrCode";

                using (var command = new SQLiteCommand(cmd, _connection))
                {
                    command.Parameters.AddWithValue("@qrCode", qrCode);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ResultSearch rs = new ResultSearch();
                            rs.QrCode = (string)reader["qr_code"];
                            rs.Content = (string)reader["content"];
                            rs.CreatedAt = (string)reader["created_at"];
                            results.Add(rs);
                        }
                    }
                }

                return results;
            }
            catch (Exception ex)
            {
                Global.WriteLog($"Error can not search result, error: {ex.Message}");
            }

            return null;
        }

        public Dictionary<string, string> GetDataLineChart()
        {
            try
            {
                string query = @"
                WITH RECURSIVE date_series AS (
                    SELECT DATE('now', '-6 days') AS day
                    UNION ALL
                    SELECT DATE(day, '+1 day')
                    FROM date_series
                    WHERE day < DATE('now')
                )
                SELECT 
                    ds.day,
                    IFNULL(COUNT(q.QR_Code), 0) AS total_count
                FROM date_series ds
                LEFT JOIN qrcodes q ON DATE(q.created_at) = ds.day
                GROUP BY ds.day
                ORDER BY ds.day ASC;";

                Dictionary<string, string> resultLineChart = new Dictionary<string, string>();

                using (var command = new SQLiteCommand(query, _connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            resultLineChart.Add(reader["day"].ToString(), reader["total_count"].ToString());
                        }
                    }
                }

                return resultLineChart;
            }
            catch (Exception ex)
            {
                Global.WriteLog($"Error can not get data line chart, error: {ex.Message}");
                return null;
            }
        }

        public bool CheckDuplicateQrCode(string qrCode)
        {
            try
            {
                string cmd = @"
                    WITH RecentRecords AS (
                    SELECT qr_code
                    FROM qrcodes
                    ORDER BY created_at DESC
                    LIMIT 1000000
                )
                SELECT qr_code
                FROM RecentRecords
                WHERE qr_code = @qrCode limit 1";

                using (var command = new SQLiteCommand(cmd, _connection))
                {
                    command.Parameters.AddWithValue("@qrCode", qrCode);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Global.WriteLog($"Error check duplicate result, error: {ex.Message}");
                return false;
            }
        }

        public bool ResetDB()
        {
            Global.WriteLog("User reset database!");

            try
            {
                using (var command = new SQLiteCommand(@"delete from qrcodes", _connection))
                {
                    command.ExecuteNonQuery();
                }

                using (var command = new SQLiteCommand(@"vacuum", _connection))
                {
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                Global.WriteLog($"Error can not reset db, error: {ex.Message}");
                return false;
            }
        }
    }
}
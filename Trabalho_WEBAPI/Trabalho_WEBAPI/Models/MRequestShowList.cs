using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Trabalho_WEBAPI.Models
{
    public class MRequestShowList
    {

        /// <summary>
        /// Constructor of MRequestShowList
        /// </summary>
        #region Constructor

        public string UnitName { get; set; }
        public string MaterialName { get; set; }
        public int MaterialQuantity { get; set; }

        public MRequestShowList()
        {
            this.UnitName = "";
            this.MaterialName = "";
            this.MaterialQuantity = 0;
        }

        public MRequestShowList(string unitName, string materialName, int materialQuantity)
        {
            this.UnitName = unitName;
            this.MaterialName = materialName;
            this.MaterialQuantity = materialQuantity;
        }

        #endregion

    }


    public class MRequestShowLists
    {

        #region Methods

        /// <summary>
        /// Method used to show requested vehicles list
        /// </summary>
        /// <returns>list of requested vehicles</returns>
        public List<MRequestShowList> MaterialRequestList()
        {
            List<MRequestShowList> list = new();
            try
            {

                /// ConnectionString
                string connectionString = "datasource=localhost;username=root;password=marccarv2001;database=trabalho_isc";

                /// Connect to database
                MySqlConnection connection = new(connectionString);

                /// Select query
                string query = "SELECT mr.unit_name, m.material_name, mr.material_amount FROM materialrequest mr INNER JOIN material m USING(material_id)";

                /// Create a commnad to execute
                MySqlCommand co = new(query, connection);

                /// Execute and read data
                connection.Open();
                using (MySqlDataReader read = co.ExecuteReader())
                {
                    while (read.Read())
                    {
                        list.Add(new MRequestShowList(read["unit_name"].ToString(), read["material_name"].ToString(), Convert.ToInt32(read["material_amount"].ToString())));
                    }
                    connection.Close();
                }
                return list;
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
                return list;
            }
        }

        #endregion

    }
}

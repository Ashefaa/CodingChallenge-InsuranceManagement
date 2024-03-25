using Insurance_Management.Entity;
using Insurance_Management.Utility;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Management.Repositories
{
    public class PolicyServiceImpl:IPolicyService
    {
        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;

        public PolicyServiceImpl()
        {
            sqlConnection = new SqlConnection(DBConnection.GetConnectionString());
            cmd = new SqlCommand();
        }

        public bool CreatePolicy(Policy policy)
        {
            cmd.CommandText = "Insert into Policy values(@PolicyId,@PolicyName)";
            cmd.Parameters.AddWithValue("@PolicyId", policy.PolicyId);
            cmd.Parameters.AddWithValue("@PolicyName", policy.PolicyName);
            sqlConnection.Open();
            cmd.Connection = sqlConnection;
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return true;

        }
        public Policy GetPolicy(int policyId)
        {
            Policy policy = new Policy();
            cmd.CommandText = "select * from Policy where policyId=@policyId";
            cmd.Parameters.AddWithValue("@policyId", policyId);
            
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                policy = new Policy();
                policy.PolicyId = (int)reader["policyId"];
                policy.PolicyName = (string)reader["policyName"];
            }
            
            sqlConnection.Close();
            return policy;
        }
        public List<Policy> GetAllPolicies()
        {
            List<Policy> policies = new List<Policy>();
            cmd.CommandText = "select * from Policies";
            
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Policy policy = new Policy();
                policy.PolicyId = (int)reader["policyId"];
                policy.PolicyName = (string)reader["policyName"];

                policies.Add(policy);
            }
            sqlConnection.Close();
            return policies;
        }
        public bool UpdatePolicy(Policy policy)
        {
            cmd.CommandText = "Update Policy Set policyName=@PolicyName Where policyId=@policyId";
            cmd.Parameters.AddWithValue("@PolicyName", policy.PolicyName);
            cmd.Parameters.AddWithValue("@policyId", policy.PolicyId);
            sqlConnection.Open();
            cmd.Connection = sqlConnection;
            
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }
        public bool DeletePolicy(int policyId)
        {
            cmd.CommandText = "Delete * from Policy where policyId=@policyId";
            cmd.Parameters.AddWithValue("@policyId", policyId);
            sqlConnection.Open();
            cmd.Connection = sqlConnection;
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }
        public bool PolicyNotFound(int policyId)
        {
            int policyNo = 0;
            cmd.CommandText="select * from policy where policyId=@PolicyId";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@PolicyId", policyId);
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                policyNo = (int)(reader["Total"]);

            }
            sqlConnection.Close();
            if (policyNo > 0)
            {
                return true;
            }
            return false;
            sqlConnection.Close();
        }
    }
}

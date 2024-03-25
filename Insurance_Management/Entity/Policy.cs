using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Management.Entity
{
    public class Policy
    {
        private int policyId;
        private string policyName;

        //Property for PolicyId
        public int PolicyId
        {
            get { return policyId; }
            set { policyId = value; }
        }

        // Property for PolicyName
        public string PolicyName
        {
            get { return policyName; }
            set { policyName = value; }
        }

        // Default Constructor
        public Policy()
        {
        }

        // Parameterized Constructor
        public Policy(int policyId, string policyName)
        {
            PolicyId = policyId;
            PolicyName = policyName;
        }

        // Method to print 
        public void PrintDetails()
        {
            Console.WriteLine($"Policy ID: {PolicyId}");
            Console.WriteLine($"Policy Name:  { PolicyName}");
        }
    }
}

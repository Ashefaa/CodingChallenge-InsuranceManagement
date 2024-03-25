using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Management.Entity
{
    public class Claim
    {
        private int claimId;
        private string claimNumber;
        private string dateFiled;
        private double claimAmount;
        private string status;
        private Policy policy;
        private Client client;

        // Property for ClaimId
        public int ClaimId
        {
            get { return claimId; }
            set { claimId = value; }
        }

        // Property for ClaimNumber
        public string ClaimNumber
        {
            get { return claimNumber; }
            set { claimNumber = value; }
        }

        // Property for DateFiled
        public string DateFiled
        {
            get { return dateFiled; }
            set { dateFiled = value; }
        }

        // Property for ClaimAmount
        public double ClaimAmount
        {
            get { return claimAmount; }
            set { claimAmount = value; }
        }

        // Property for Status
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        // Property for Policy
        public Policy Policy
        {
            get { return policy; }
            set { policy = value; }
        }

        // Property for Client
        public Client Client
        {
            get { return client; }
            set { client = value; }
        }

        // Default Constructor
        public Claim()
        {
        }

        // Parameterized Constructor
        public Claim(int claimId, string claimNumber, string dateFiled, double claimAmount, string status, Policy policy, Client client)
        {
            this.ClaimId = claimId;
            this.ClaimNumber = claimNumber;
            this.DateFiled = dateFiled;
            this.ClaimAmount = claimAmount;
            this.Status = status;
            this.Policy = policy;
            this.Client = client;
        }

        //to print 
        public void PrintDetails()
        {
            Console.WriteLine($"Claim ID:  {ClaimId}");
            Console.WriteLine($"Claim Number:  {ClaimNumber}");
            Console.WriteLine($"Date Filed:  {DateFiled}");
            Console.WriteLine($"Claim Amount:  {ClaimAmount}");
            Console.WriteLine($"Status:  {Status}");
            Console.WriteLine($"Policy:  {Policy.PolicyId} ,  {Policy.PolicyName}");
            Console.WriteLine($"Client: {Client.ClientId}, {Client.ClientName}");
        }

    }
}

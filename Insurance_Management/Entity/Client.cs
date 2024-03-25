using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Management.Entity
{
    public class Client
    {
        private int clientId;
        private string clientName;
        private string contactInfo;
        private Policy policy;

        // Property for ClientId
        public int ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }

        // Property for ClientName
        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }

        // Property for ContactInfo
        public string ContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }

        // Property for Policy
        public Policy Policy
        {
            get { return policy; }
            set { policy = value; }
        }

        // Default Constructor
        public Client()
        {
        }

        // Parameterized Constructor
        public Client(int clientId, string clientName, string contactInfo, Policy policy)
        {
            ClientId = clientId;
            ClientName = clientName;
            ContactInfo = contactInfo;
            Policy = policy;
        }

        //Method to print 
        public void PrintDetails()
        {
            Console.WriteLine($"Client ID:  {ClientId}");
            Console.WriteLine($"Client Name:  {ClientName}");
            Console.WriteLine($"Contact Info: {ContactInfo}");
            Console.WriteLine($"Policy: {Policy.PolicyId} ,{Policy.PolicyName}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Management.Entity
{
    public class PaymentClaim
    {
        private int paymentId;
        private string paymentDate;
        private double paymentAmount;
        private Client client;

        // Property for PaymentId
        public int PaymentId
        {
            get { return paymentId; }
            set { paymentId = value; }
        }

        // Property for PaymentDate
        public string PaymentDate
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }

        // Property for PaymentAmount
        public double PaymentAmount
        {
            get { return paymentAmount; }
            set { paymentAmount = value; }
        }

        // Property for Client
        public Client Client
        {
            get { return client; }
            set { client = value; }
        }

        // Default Constructor
        public PaymentClaim()
        {
        }

        // Parameterized Constructor
        public PaymentClaim(int paymentId, string paymentDate, double paymentAmount, Client client)
        {
            PaymentId = paymentId;
            PaymentDate = paymentDate;
            PaymentAmount = paymentAmount;
            Client = client;
        }

        // Method to print all 
        public void PrintDetails()
        {
            Console.WriteLine($"Payment ID:  {PaymentId}");
            Console.WriteLine($"Payment Date:  {PaymentDate}");
            Console.WriteLine($"Payment Amount:  {PaymentAmount}");
            Console.WriteLine($"Client: {Client.ClientId},  {Client.ClientName}");
        }

    }
}

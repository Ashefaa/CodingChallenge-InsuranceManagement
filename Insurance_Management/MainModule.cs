using Insurance_Management.Entity;
using Insurance_Management.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Management
{
    internal class MainModule
    {
        public void Run()
        {
            Policy policy = new Policy();
            while(true)
            {
                InsuranceServiceImpl insuranceServiceImpl = new InsuranceServiceImpl();
                Console.WriteLine("Insurance Management System");
                Console.WriteLine("1.Create POlicy");
                Console.WriteLine("2.Get Policy");
                Console.WriteLine("3.Get All Policies");
                Console.WriteLine("4.Update Policy");
                Console.WriteLine("6.Delete Policy");
                Console.WriteLine("Enter your Input");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter your Policy Id:");
                        int policyId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your Policy Name:");
                        string policyName = Console.ReadLine();
                        policy = new Policy() { PolicyId = policyId, PolicyName = policyName };
                        insuranceServiceImpl.AddPolicyService(policy);
                        break;
                    case 2:
                        Console.WriteLine("Enter your Policy Id:");
                        int GetpolicyId = int.Parse(Console.ReadLine());
                        insuranceServiceImpl.GetPolicyService(GetpolicyId);
                        break;
                    case 3:
                        //policy = new Policy();
                        insuranceServiceImpl.GetAllPolicyService();
                        break;
                    case 4:
                        Console.WriteLine("Enter your Policy Id:");
                        int UpdatepolicyId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your Policy Name:");
                        string UpdatepolicyName = Console.ReadLine();
                        policy = new Policy() { PolicyId = UpdatepolicyId, PolicyName = UpdatepolicyName };
                        insuranceServiceImpl.UpdatePolicyService(policy);
                        break;
                    case 5:
                        Console.WriteLine("Enter your Policy Id:");
                        int DeletepolicyId = int.Parse(Console.ReadLine());
                        insuranceServiceImpl.DeletepolicyService(DeletepolicyId);
                        break;
                    default:
                        Console.WriteLine("Enter a valid Choice");
                        break;

                }
            }
        }
    }
}

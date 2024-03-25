using Insurance_Management.Entity;
using Insurance_Management.Exceptions;
using Insurance_Management.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Management.Service
{
    internal class InsuranceServiceImpl
    {
        public InsuranceServiceImpl()
        { }

        PolicyServiceImpl policyService = new PolicyServiceImpl();

        public void AddPolicyService(Policy policy)
        {
            try
            {
                policyService.CreatePolicy(policy);
                Console.WriteLine("Policy Added");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void GetPolicyService(int policyId)
        {
            try
            {
                PolicyNotFoundException.PolicyNotFound(policyId);
                policyService.GetPolicy(policyId);
                Console.WriteLine("Policy Shown");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void GetAllPolicyService()
        {
            try
            {
                policyService.GetAllPolicies();
                Console.WriteLine("All Policies Shown");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void UpdatePolicyService(Policy policy)
        {
            try
            {
                PolicyNotFoundException.PolicyNotFound(policy.PolicyId);
                policyService.UpdatePolicy(policy);
                Console.WriteLine("Policy Updated");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void DeletepolicyService(int policyId)
        {
            try
            {
                PolicyNotFoundException.PolicyNotFound(policyId);
                policyService.DeletePolicy(policyId);
                Console.WriteLine("Policy Deleted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        

    }
}

using Insurance_Management.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Management.Exceptions
{
    internal class PolicyNotFoundException:Exception
    {
        public PolicyNotFoundException(string message) : base(message)
        {
        }
        public static void PolicyNotFound(int policyId)
        {
            PolicyServiceImpl policyService = new PolicyServiceImpl();
            if (!policyService.PolicyNotFound(policyId))
                throw new PolicyNotFoundException("Policy Not Found!!!");
        }
    }
}

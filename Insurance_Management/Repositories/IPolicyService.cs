using Insurance_Management.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Management.Repositories
{
    public interface IPolicyService
    {
        bool CreatePolicy(Policy policy);
        Policy GetPolicy(int policyId);
        List<Policy> GetAllPolicies();
        bool UpdatePolicy(Policy policy);
        bool DeletePolicy(int policyId);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class ClaimRepository
    {
        Queue<Claim> _claimqueue = new Queue<Claim>();

        public void Add(Claim s)
        {
            _claimqueue.Enqueue(s);
        }
        public Queue<Claim> GetClaimList()
        {
            return _claimqueue; 
        }
        public void CurrentClaimFinished()
        {
            _claimqueue.Dequeue();
        }
        public void PrintList(Queue<Claim> list)
        {
            foreach (Claim item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

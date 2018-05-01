using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First.Models
{
    public static class Repository
    {
        static List<GuestResponse> listResponses;
        static Repository()
        {
            listResponses = new List<GuestResponse>();
        }

        public static IEnumerable<GuestResponse> getReponses()
        {
            return listResponses;
        }
        public static void  AddResponse(GuestResponse response)
        {
            listResponses.Add(response);
        }
    }
}

using System.Diagnostics;
using OKRs.Model;

namespace OKRs.Service
{
    public class HandleOKRs
    {
        public static int GetNumberKrOfOKRs(string idOKR, List<KR> list_KR)
        {
            int count = 0;
            foreach (KR kr in list_KR)
            {
                if (kr.idOKRs == idOKR)
                {
                    count++;
                }
            }
            return count;
        }



        public static List<KR> GetKROfOKR(string idOKR, List<KR> list_KR)
        {
            List<KR> list = new List<KR>();
            foreach (KR kr in list_KR)
            {
                if (kr.idOKRs == idOKR)
                {
                    list.Add(kr);
                }
            }
            return list;
        }
    }
}
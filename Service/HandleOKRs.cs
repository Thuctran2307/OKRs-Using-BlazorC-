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


        public static string ConvertToConfident(int i){
            switch (i)
            {
                case 1:
                    return "Rất tốt";
                case 2:
                    return "Ổn";
                case 3:
                    return "Không ổn";
                default:
                    return "Chưa đánh giá";
            }
        }

        public static string ConvertStatus(float i){
            switch (i)
            {
                case -1:
                    return "";
                case 0:
                    return "Check-in nháp";
                case 1:
                    return "Đã xác nhận checkin nháp";
                case 2:
                    return "Đã check-in";
                    case 3:
                    return "Đã xác nhận";
                default:
                    return "";
            }
        }

        public static string ConvertTicksToDate(long ticks)
        {
            DateTime date = new DateTime(ticks);
            return date.ToString("dd/MM/yyyy");
        }
    }
}
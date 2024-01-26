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
            /*<select  @bind="OKR_Current.confident" >
                                                <option value="0">- Chọn -</option>
                                                <option value="1">Rất tốt</option>
                                                <option value="2">Ổn</option>
                                                <option value="3">Không ổn</option>
                                            </select>
            */
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
    }
}
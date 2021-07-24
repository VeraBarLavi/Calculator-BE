using Calculates.DB;
using System.Collections.Generic;


namespace Calculates.Core
{
    public interface ICalculatesServices
    {
        List<Calculate> GetCalculates();
        Calculate GetCalculate(int id);
        Calculate CreateCalculate(Calculate calculate);
        void DeleteCalculate(Calculate calculate);
        Calculate EditCalculate(Calculate calculate);

    }
}

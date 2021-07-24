using Calculates.DB;
using Calculates.Operation;
using System.Collections.Generic;
using System.Linq;

namespace Calculates.Core
{
    public class CalculatesServices : ICalculatesServices
    {
        private readonly AppDbContext _context;

        //TODO: MANAGE DATA PER USER!!!!
        //private readonly DB.User _user;

        public CalculatesServices(AppDbContext context)
        {
            _context = context;
            //_user = _context.Users
               // .First(u => u.Username == httpContextAccessor.HttpContext.User.Identity.Name);

        }

        public Calculate CreateCalculate(DB.Calculate calculate)
        {
            IOperator oper;
            oper = OperationFactory.createOperation(calculate.Operation);
            calculate.Result = oper.getResult(calculate.Number1, calculate.Number2);

           //calculate.User = _user;
            _context.Add(calculate);
            _context.SaveChanges();

            return (Calculate)calculate;
        }

        public void DeleteCalculate(Calculate calculate)
        {
            var dbCalculate = _context.Calculates.First(/* e => e.User.Id == _user.Id && */
                                                        e => e.Id == calculate.Id);
            _context.Remove(dbCalculate);
            _context.SaveChanges();
        }

        public Calculate EditCalculate(Calculate calculate)
        {
            var dbCalculate = _context.Calculates
                 .Where(/* e => e.User.Id == _user.Id && */
                        e => e.Id == calculate.Id)
                 .First();


            IOperator oper;
            oper = OperationFactory.createOperation(calculate.Operation);
            calculate.Result = oper.getResult(calculate.Number1, calculate.Number2);

            dbCalculate.Number1 = calculate.Number1;
            dbCalculate.Number2 = calculate.Number2;
            dbCalculate.Operation = calculate.Operation;
            dbCalculate.Result = calculate.Result;

            _context.SaveChanges();

            return calculate;
        }

        public Calculate GetCalculate(int id) =>
            _context.Calculates
                .Where(/* e => e.User.Id == _user.Id && */
                        e => e.Id == id)
                .Select(e => (Calculate)e)
                .First();

        public List<Calculate> GetCalculates() =>
            _context.Calculates/*.Where(e => e.User.Id == _user.Id && e.Id == id)*/.ToList();
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface INotifier
    {
        void Notify();

        bool CanRun();

    }

    public class Notifier1 : INotifier
    {
        public bool CanRun()
        {
            throw new NotImplementedException();

            //_notifiers.Where(x => x.CanRun()).ToList().ForEach(x => x.Notify());
        }

        public void Notify()
        {
            Debug.WriteLine("Debugging from Notifier 1");
        }
    }

}

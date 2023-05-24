using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Application.Common
{
    public interface ILoggerManager
    {
        void LogInformation(string message);
        void LogWarning(string message);
        void LogError(string message);
        void LogDebugging(string message);
    }
}

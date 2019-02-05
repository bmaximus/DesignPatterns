using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class SingletonPattern
    {
        private string Instance = Guid.NewGuid().ToString();

        protected static SingletonPattern singletonPattern = null;

        public static SingletonPattern GetSingleton()
        {
            if (singletonPattern == null)
            {
                singletonPattern = new SingletonPattern();
            }

            return singletonPattern;
        }

        public string GetInstance()
        {
            return Instance;
        }
    }
}

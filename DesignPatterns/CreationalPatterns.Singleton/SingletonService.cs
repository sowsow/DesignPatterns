using System;

namespace CreationalPatterns.Singleton
{
    public class SingletonService : ISingletonService
    {
        private static SingletonService _instance;

        private static readonly object _syncObject = new object();

        public string Value { get; set; }

        private SingletonService()
        {
        }

        public static SingletonService GetConfigurationServiceSingleton(string value)
        {
            if (_instance != null)
            {
                return _instance;
            }

            lock (_syncObject)
            {
                if (_instance == null)
                {
                    _instance = new SingletonService { Value = value };
                }
            }

            return _instance;
        }

        public void DoSomething()
        {
            Console.WriteLine($"{Value} from SingletonService.");
        }
    }
}

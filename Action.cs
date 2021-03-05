using System;

namespace HW_2_4
{
    public class Action
    {
        private Logger _logger;

        public Action()
        {
            _logger = Logger.GetLogger();
        }

        public void StartMethod()
        {
            _logger.Info();
            Console.WriteLine("Start method");
        }

        public void SkippedLogicInMethod()
        {
            var num = 9;
            try
            {
               var res = num / 0;
            }
            catch
            {
                Console.WriteLine("Skipped logic in method");
            }
            finally
            {
                _logger.Warning();
            }
        }

        public void BrokenLogic()
        {
           var num = 9;
           try
            {
                var res = num / 0;
            }
            catch
            {
                Console.WriteLine("I broke loggic");
            }
            finally
            {
                _logger.Error();
            }
        }
    }
}

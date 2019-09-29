using System;
using System.Configuration;
namespace Kpo4381_nmv.Utility
{
   public class AppConfigUtility
    {
        public string AppSettings(string name)
        {
                //Если конфигурационный параметр определен
            if (ConfigurationManager.AppSettings[name] != null)
                //то
                //вернуть значение параметра в виде строки
                return ConfigurationManager.AppSettings[name];
            //иначе
            //веpнуть пустую строку
            else return String.Empty;
        }       
    }
}

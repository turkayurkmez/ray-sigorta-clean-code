using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class ReportGenerator
    {
        /* Bir excel dosyasından verileri okuyup bir PDF formatına dönüştürüyor*/
        public string ExcelFilePath { get; set; }

        public ReportGenerator(string filePath)
        {
            checkParameterRules(filePath);
            ExcelFilePath = filePath;


        }

        /// <summary>
        /// Oluşturulacak raporun ayarlarını belirtiniz
        /// </summary>
        /// <param name="options">İlgili raporun opsiyonel seçeneklerini belirtiniz</param>
        public void SetReportDetails(ReportOptions options)
        {
            //Her zaman tüm parametreleri tek bir tipin altına almak mümkün olmayabilir. Mümkünse bu yol tercih edilmelidir.
        }

        private void checkParameterRules(string filePath)
        {
            nullArgumentCheck(filePath);
            fileExistsCheck(filePath);
            formatAvailableCheck(filePath);
        }

        private void formatAvailableCheck(string filePath)
        {
            if (!isAvailable(filePath))
            {
                throw new FileFormatNotAvailableException();

            }
        }

        private static void fileExistsCheck(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Dosya bulunamadı");
            }
        }

        private static void nullArgumentCheck(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException(nameof(filePath), "Lütfen dosyası belirtin");
            }
        }

        private bool isAvailable(string filePath)
        {
            return false;
        }
    }
}

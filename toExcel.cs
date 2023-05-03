using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using OfficeOpenXml;

namespace Registro_Alumnos_profesores
{
    class toExcel
    {
        //Exportar a Excel
        public static void ExportarAExcel(DataTable datos, string nombreArchivo)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())

            {
                var worksheet = package.Workbook.Worksheets.Add("Datos");
                worksheet.Cells["A1"].LoadFromDataTable(datos, true);
                var stream = new MemoryStream(package.GetAsByteArray());
                var saveFileDialog = new Microsoft.Win32.SaveFileDialog
                {
                    Filter = "Archivo de Excel (*.xlsx)|*.xlsx",
                    FileName = nombreArchivo
                };
                if (saveFileDialog.ShowDialog() == true)
                {
                    using (var fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                    {
                        stream.WriteTo(fileStream);
                    }
                }
            }
        }
        //------------------------------------------------------------------------------------------------------------------------        
    }
}

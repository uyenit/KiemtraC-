using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra.DAL.Entity
{
    class NhomDanhBa
    {
        public string TenNhom { get; set; }
        public static List<NhomDanhBa> GetListFromFile(string pathData)
        {
            var arrayLines = File.ReadAllLines(pathData);
            List<NhomDanhBa> result = new List<NhomDanhBa>();
            foreach (var line in arrayLines)
            {
                var lsValue = line.Split(new char[] { '#' });
                var nhomdanhba = new NhomDanhBa
                {
                    TenNhom=lsValue[1],
                };
                
                    result.Add(nhomdanhba);
            }
            return result;
        }
    }
}

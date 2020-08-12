using Desafio.Nibo.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Nibo.Business.Services
{
    public class OFXFileConverter : BaseService, IOFXFileConverter
    {
        
        public OFXFileConverter(INotifier notifier) : base(notifier)
        {
        }

        public string ConvertOFXFile(IFormFile file)
        {
            string content = string.Empty;

            if (file.Length.Equals(0))
            {
                Notify("The file is empty");
                return string.Empty;
            }

            string path = Path.GetTempFileName();

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                file.CopyToAsync(stream);
            }

            using(StreamReader reader = new StreamReader(file.OpenReadStream()))
            {
                content = reader.ReadToEnd();
            }

            return content;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}

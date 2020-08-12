using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Desafio.Nibo.Business.Interfaces
{
    public interface IOFXFileConverter : IDisposable
    {
        string ConvertOFXFile(IFormFile file);
    }
}

using RequestApplication.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RequestApplication.BLL.Concrete
{
    public class DocumentBLL : IDocumentBLL
    {
        private readonly IRequestBLL _requestBLL;

        public DocumentBLL(IRequestBLL requestBLL)
        {
            _requestBLL = requestBLL;
        }


        public byte[] Download(string file)
        {
            string filePath = $"wwwroot\\document\\{file}";

            byte[] fileBytes = File.ReadAllBytes(filePath);

            return fileBytes;
        }

        public byte[] Report(int requestId)
        {
            var request = _requestBLL.GetRequest(requestId);

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (StreamWriter streamWriter = new StreamWriter(memoryStream))
                {
                    streamWriter.WriteLine("Talep= " + request.Description + "\nYanıt= " + request.Reply);
                    streamWriter.Flush();

                    byte[] fileBytes = memoryStream.GetBuffer();

                    return fileBytes;

                }
            }

        }
    }
}

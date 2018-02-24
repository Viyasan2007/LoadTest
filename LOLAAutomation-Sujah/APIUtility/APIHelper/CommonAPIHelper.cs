using APIUtility.APIHelper;
using Newtonsoft.Json;
using OpenQA.Selenium;
using System;
using System.Net;
using TestAutomationFrameWork.DataBaseAPIAutomation;

namespace TestAutomationFrameWork
{
    public class CommonAPIHelper
    {
        public IWebDriver driver;

        #region Contructors
        public CommonAPIHelper(IWebDriver driver)
        {
            this.driver = driver;
        }
        #endregion

        public string GetAPIResponse(string url, string contentType, string methodType, string loanNum, string tableName)
        {
            var body = "{\"LoanNumber\": \"" + loanNum + "\", \"OutputClassFormat\": true,\"QueryType\": \"" + tableName + "\"}";
            string result;
            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = contentType;
                result = client.UploadString(url, methodType, body);
            }
            return result;
        }

        public string GetAPIGetMethodResponse(IWebDriver driver,string preUrl,string versionNumber,string number)
        {
            var url = preUrl+number+"?format=json"; ;
            string result;
            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type", "application/json");
                client.Headers.Add("X-Mobius-Version", versionNumber);
                client.Credentials = CredentialCache.DefaultCredentials;
                result = client.DownloadString(url);
            }
            return result;
        }

        public BankerPipeline BankerPipelineResult(string response)
        {
            var deserializedItem = JsonConvert.DeserializeObject<BankerPipeline>(response);
            return deserializedItem;
        }

        public DataIQImport DataIQImportResult(string response)
        {
            var deserializedItem = JsonConvert.DeserializeObject<DataIQImport>(response);
            return deserializedItem;
        }

        public Mobius_LoanTable LoanResult(string response)
        {
            var deserializedItem = JsonConvert.DeserializeObject<Mobius_LoanTable>(response);
            return deserializedItem;
        }

        public Mobius_ClientMapping ClientMappingResult(string response)
        {
            var deserializedItem = JsonConvert.DeserializeObject<Mobius_ClientMapping>(response);
            return deserializedItem;
        }

       public Panorama_ClientDetails clientDetailsResult(string response)
        {
            var deserializedItem = JsonConvert.DeserializeObject<Panorama_ClientDetails>(response);
            return deserializedItem;
        }

        public Panorama_SecondClientDetails SecondClientDetailsResult(string response)
        {
            var deserializedItem = JsonConvert.DeserializeObject<Panorama_SecondClientDetails>(response);
            return deserializedItem;
        }

    }
}

    

    






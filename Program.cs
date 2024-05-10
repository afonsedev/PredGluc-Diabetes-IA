using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace CallRequestResponseService
{
    class Program
    {
        static void Main(string[] args)
        {
            InvokeRequestResponseService().Wait();
        }

        static async Task InvokeRequestResponseService()
        {
            var handler = new HttpClientHandler()
            {
                ClientCertificateOptions = ClientCertificateOption.Manual,
                ServerCertificateCustomValidationCallback =
                        (httpRequestMessage, cert, cetChain, policyErrors) => { return true; }
            };

            using (var client = new HttpClient(handler))
            {
                // Request data goes here
                #region json
                var requestBody = @"{
                  ""Inputs"": {
                    ""input1"": [
                      {
                        ""PatientID"": 1882185,
                        ""Pregnancies"": 9,
                        ""PlasmaGlucose"": 104,
                        ""DiastolicBloodPressure"": 51,
                        ""TricepsThickness"": 7,
                        ""SerumInsulin"": 24,
                        ""BMI"": 27.36983156,
                        ""DiabetesPedigree"": 1.3504720469999998,
                        ""Age"": 43
                      },
                      {
                        ""PatientID"": 1662484,
                        ""Pregnancies"": 6,
                        ""PlasmaGlucose"": 73,
                        ""DiastolicBloodPressure"": 61,
                        ""TricepsThickness"": 35,
                        ""SerumInsulin"": 24,
                        ""BMI"": 18.74367404,
                        ""DiabetesPedigree"": 1.074147566,
                        ""Age"": 75
                      },





                      {
                        ""PatientID"": 1228510,
                        ""Pregnancies"": 0,
                        ""PlasmaGlucose"": 100,
                        ""DiastolicBloodPressure"": 50,
                        ""TricepsThickness"": 29,
                        ""SerumInsulin"": 243,
                        ""BMI"": 34.69215364,
                        ""DiabetesPedigree"": 0.7411599259999999,
                        ""Age"": 18
                      },

                         {
        ""PatientID"": 3849003,
        ""Pregnancies"": 3,
        ""PlasmaGlucose"": 128,
        ""DiastolicBloodPressure"": 48,
        ""TricepsThickness"": 5,
        ""SerumInsulin"": 30,
        ""BMI"": 9.481144774,
        ""DiabetesPedigree"": 1.279022951,
        ""Age"": 26
      },
      {
        ""PatientID"": 5692012,
        ""Pregnancies"": 5,
        ""PlasmaGlucose"": 90,
        ""DiastolicBloodPressure"": 64,
        ""TricepsThickness"": 28,
        ""SerumInsulin"": 180,
        ""BMI"": 25.89285788,
        ""DiabetesPedigree"": 0.771978274,
        ""Age"": 54
      },
      {
        ""PatientID"": 7281934,
        ""Pregnancies"": 1,
        ""PlasmaGlucose"": 98,
        ""DiastolicBloodPressure"": 52,
        ""TricepsThickness"": 5,
        ""SerumInsulin"": 29,
        ""BMI"": 26.67890857,
        ""DiabetesPedigree"": 0.519839286,
        ""Age"": 25
      },
      {
        ""PatientID"": 9283745,
        ""Pregnancies"": 8,
        ""PlasmaGlucose"": 102,
        ""DiastolicBloodPressure"": 89,
        ""TricepsThickness"": 32,
        ""SerumInsulin"": 45,
        ""BMI"": 29.29917045,
        ""DiabetesPedigree"": 0.356416583,
        ""Age"": 41
      },
      {
        ""PatientID"": 1203847,
        ""Pregnancies"": 4,
        ""PlasmaGlucose"": 135,
        ""DiastolicBloodPressure"": 70,
        ""TricepsThickness"": 26,
        ""SerumInsulin"": 30,
        ""BMI"": 21.72334693,
        ""DiabetesPedigree"": 0.78185014,
        ""Age"": 38
      },
      {
        ""PatientID"": 1459723,
        ""Pregnancies"": 7,
        ""PlasmaGlucose"": 115,
        ""DiastolicBloodPressure"": 0,
        ""TricepsThickness"": 33,
        ""SerumInsulin"": 17,
        ""BMI"": 29.58986511,
        ""DiabetesPedigree"": 0.728466461,
        ""Age"": 30
      },
      {
        ""PatientID"": 1759384,
        ""Pregnancies"": 2,
        ""PlasmaGlucose"": 114,
        ""DiastolicBloodPressure"": 88,
        ""TricepsThickness"": 5,
        ""SerumInsulin"": 10,
        ""BMI"": 37.91227125,
        ""DiabetesPedigree"": 0.465128112,
        ""Age"": 55
      },
      {
        ""PatientID"": 1982734,
        ""Pregnancies"": 5,
        ""PlasmaGlucose"": 138,
        ""DiastolicBloodPressure"": 100,
        ""TricepsThickness"": 29,
        ""SerumInsulin"": 25,
        ""BMI"": 32.71065725,
        ""DiabetesPedigree"": 0.514030569,
        ""Age"": 60
      },
      {
        ""PatientID"": 2093847,
        ""Pregnancies"": 1,
        ""PlasmaGlucose"": 109,
        ""DiastolicBloodPressure"": 82,
        ""TricepsThickness"": 15,
        ""SerumInsulin"": 37,
        ""BMI"": 22.27434814,
        ""DiabetesPedigree"": 0.647923848,
        ""Age"": 72
      },
      {
        ""PatientID"": 2123948,
        ""Pregnancies"": 0,
        ""PlasmaGlucose"": 95,
        ""DiastolicBloodPressure"": 65,
        ""TricepsThickness"": 26,
        ""SerumInsulin"": 32,
        ""BMI"": 32.72687115,
        ""DiabetesPedigree"": 0.438768563,
        ""Age"": 36
      },
      {
        ""PatientID"": 2374837,
        ""Pregnancies"": 3,
        ""PlasmaGlucose"": 111,
        ""DiastolicBloodPressure"": 94,
        ""TricepsThickness"": 20,
        ""SerumInsulin"": 39,
        ""BMI"": 26.46757267,
        ""DiabetesPedigree"": 0.6199457,
        ""Age"": 48
      },
      {
        ""PatientID"": 2485739,
        ""Pregnancies"": 6,
        ""PlasmaGlucose"": 128,
        ""DiastolicBloodPressure"": 92,
        ""TricepsThickness"": 3,
        ""SerumInsulin"": 36,
        ""BMI"": 23.47976984,
        ""DiabetesPedigree"": 0.41789657,
        ""Age"": 42
      }
                    ]
                  },
                  ""GlobalParameters"": {}
                }";
                #endregion


                const string apiKey = "your_apikey_here";
                if (string.IsNullOrEmpty(apiKey))
                {
                    throw new Exception("A key should be provided to invoke the endpoint");
                }

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                client.BaseAddress = new Uri("http://85ceab0a-0281-4171-9679-9b0d5b657585.eastus.azurecontainer.io/score");

                var content = new StringContent(requestBody);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                HttpResponseMessage response = await client.PostAsync("", content);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    dynamic jsonResponse = JsonConvert.DeserializeObject(result);
                    foreach (var item in jsonResponse.Results.WebServiceOutput0)
                    {
                        double scoredProbabilities = item["Scored Probabilities"];
                        int scoredProbabilitiesInt = (int)(scoredProbabilities * 100);

                        //Console.WriteLine("Tá tudo certo até aqui");                       
                        //Console.WriteLine("checkpoint 2");

                        if (scoredProbabilitiesInt > 0.5 * 100)
                        {
                            Console.WriteLine($"Resultado: {scoredProbabilitiesInt} | Análise: Paciente Diabético");
                        }
                        else
                        {
                            Console.WriteLine($"Resultado: {scoredProbabilitiesInt} | Análise: Paciente Não Diabético");
                        }
                    }
                }

                else
                {
                    Console.WriteLine(string.Format("The request failed with status code: {0}", response.StatusCode));
                    Console.WriteLine(response.Headers.ToString());
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseContent);
                }
            }

            Console.ReadKey();
        }
    }
}

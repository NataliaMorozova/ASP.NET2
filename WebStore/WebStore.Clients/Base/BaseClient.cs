using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;
namespace WebStore.Clients.Base
{

    public abstract class BaseClient
    {

        protected HttpClient Client;

        protected abstract string ServiceAddress { get; set; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="configuration">Конфигурация проекта</param>
        protected BaseClient(IConfiguration configuration)
        {
            // Создаем экземпляр клиента
            Client = new HttpClient
            {
                // Базовый адрес, на котором будут хостится сервисы
                BaseAddress = new Uri(configuration["ClientAdress"])
            };
            Client.DefaultRequestHeaders.Accept.Clear();

        Client.DefaultRequestHeaders.Accept.Add(new
        MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;

namespace IsDisco.Rest.Implementations
{
    public abstract class UserClientImpl : Interfaces.UserClient<T>
    {
        private static readonly string restService = "https://localhost:5001/api/";
        private static HttpClient httpClient = new HttpClient();
        private String servicePath;

        public UserClientImpl(string servicePath)
        {
            this.servicePath = servicePath;
        }

        public async System.Threading.Tasks.Task<T> Add(T element)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync(restService + servicePath, element);
            if (response.IsSuccessStatusCode)
            {
                return response.StatusCode;
            }
            else
                throw new NotImplementedException();
        }

        public async System.Threading.Tasks.Task<T> Delete(int id)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync(restService + servicePath + $"{id}");
            return response.StatusCode;
        }

        public async System.Threading.Tasks.Task<T> Get(int id)
        {
            T element = null;
            HttpResponseMessage response = await httpClient.GetAsync(restService + servicePath + $"{id}");
            if (response.IsSuccessStatusCode)
            {
                element = await response.Content.ReadAsAsync<T>();
                return element;
            }
            else
                throw new NotImplementedException();
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<T>> GetAll()
        {
            List<T> elements = new List<T>();            
            HttpResponseMessage response = await httpClient.GetAsync(restService + servicePath);
            if (response.IsSuccessStatusCode)
            {
                elements = await response.Content.ReadAsAsync<T>();
                return elements;
            }
            else
                throw new NotImplementedException();
        }

        public async System.Threading.Tasks.Task<T> Update(int id, T newElement)
        {
            HttpResponseMessage response = await httpClient.PutAsJsonAsync(restService + servicePath + $"{id}");
            if (response.IsSuccessStatusCode)
            {
                newElement = await response.Content.ReadAsAsync<T>();
                return newElement;
            }
            else
                throw new NotImplementedException();
        }
    }
}

using Frame_Manager.Data;
using Frame_Manager.Model.Entity;
using Frame_Manager.Repository;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace Frame_Manager.Service
{
    public class CounterService
    {
        HistoryRepository historyRepository;
        HttpClient _httpClient = new HttpClient();
        private readonly string _url = "https://membershipbe.phototimevn.com/v1/frame/get-list";
        public CounterService(HistoryRepository historyRepository)
        {
            this.historyRepository = historyRepository;
            
        }

        public async Task<List<Frame>> counterFrame()
        {
            List<History> historydata = await historyRepository.getHistory();
            List<Frame> dataFrame = await GetFrame(1);


            return null;
        }
        public async Task<List<Frame>> GetFrame(int page)
        {
            var response = await _httpClient.GetAsync(_url);

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                List<Frame> frame = JsonConvert.DeserializeObject<List<Frame>>(data);
                if(frame != null)
                {
                    return frame;
                }
                return null;
            }
            else
            {
                throw new HttpRequestException($"Error fetching data. Status code: {response.StatusCode}");
            }
        }
    }
}

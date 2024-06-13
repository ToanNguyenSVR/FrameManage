using Frame_Manager.Data;
using Frame_Manager.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace Frame_Manager.Repository
{
    public class HistoryRepository 
    {

        private AppDBConntext _context;

        public HistoryRepository(AppDBConntext context)
        {
            _context = context;
        }

        public async Task<List<History>> getHistory()
        {
           
            string query = "\r\nSELECT COLOR4 , FRAMES , COUNT(*) as Number \r\nFROM wyvmediavina.dbo.TB_HIS003\r\nWHERE  WORK_DATE  BETWEEN  '2024-05-01' AND '2024-05-31'\r\nGROUP By COLOR4  ,FRAMES ;\r\n";
            return await _context.Set<History>().FromSqlRaw(query).ToListAsync();

        }
    }
}

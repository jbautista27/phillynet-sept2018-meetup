using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using XyzApi.Models;
using XyzApi.Services.Impl;
using XyzApi.Utility;

namespace XyzApi.Repository.Impl
{
    public class WidgetRepository : IWidgetRepository
    {
        private readonly IDatabaseConnectionFactory _connectionFactory;

        public WidgetRepository(IDatabaseConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<IEnumerable<Widget>> GetWidgets()
        {
            throw new System.NotImplementedException();
        }

        public async Task AddWidget(string widgetName)
        {
            throw new System.NotImplementedException();
        }
    }
}
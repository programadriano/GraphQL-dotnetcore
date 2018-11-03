using Api.Infra;
using Api.Infra.Business;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class LeaderboardService : IRepository<Leaderboard>
    {

        private DataContext _context;
        private IConfiguration Configuration { get; }
        private readonly string _connection;

        public LeaderboardService(DataContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
            _connection = Configuration.GetSection("SQLConnection:ConnectionString").Value;
        }

        public void Add(Leaderboard obj)
        {
            obj.DataDeCriacao = DateTime.Now;
            obj.DataDeAtualizacao = DateTime.Now;
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Leaderboard Get(int id)
        {
            SqlConnection conexao = new SqlConnection(_connection);
            conexao.Open();
            var vm = conexao.Query<Leaderboard>("select * from Leaderboard where id = @id and Deletado = 0 ", new { id = id }).FirstOrDefault();
            vm.LeaderboardGroupInfo = conexao.Query<LeaderboardGroupInfo>("select * from LeaderboardGroupInfo where leaderboardId = @id and Deletado = 0 ", new { id = vm.Id }).ToList();
            conexao.Close();

            return vm;
        }

        public IList<Leaderboard> GetAll()
        {
            SqlConnection conexao = new SqlConnection(_connection);
            conexao.Open();
            var vm = conexao.Query<Leaderboard>("select * from Leaderboard where Deletado = 0").ToList();

            foreach (var item in vm)
            {
                item.LeaderboardGroupInfo = conexao.Query<LeaderboardGroupInfo>("select * from LeaderboardGroupInfo where leaderboardId = @id and Deletado = 0 ", new { id = item.Id }).ToList();
            }

            conexao.Close();
            return vm;
        }

        public void Remove(int id)
        {
            var obj = Get(id);
            obj.DataDeAtualizacao = DateTime.Now;
            obj.Deletado = true;

            _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Update(Leaderboard obj)
        {
            obj.DataDeAtualizacao = DateTime.Now;
            _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}

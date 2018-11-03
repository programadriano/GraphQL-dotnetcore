using Api.Infra;
using Api.Infra.Business;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


namespace Api.Models
{
    public class ChampionshipService : IRepository<Championship>
    {
        private DataContext _context;
        private IConfiguration Configuration { get; }
        private readonly string _connection;      

        public ChampionshipService(DataContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
            _connection = Configuration.GetSection("SQLConnection:ConnectionString").Value; 
        }

        public void Add(Championship obj)
        {
            obj.DataDeCriacao = DateTime.Now;
            obj.DataDeAtualizacao = DateTime.Now;
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Championship Get(int id)
        {
            SqlConnection conexao = new SqlConnection(_connection);
            conexao.Open();
            var vm = conexao.Query<Championship>("select * from Championship where id = @id and Deletado = 0 ", new { id = id }).FirstOrDefault();
            conexao.Close();

            return vm;
        }

        public IList<Championship> GetAll()
        {
            SqlConnection conexao = new SqlConnection(_connection);
            conexao.Open();
            var vm = conexao.Query<Championship>("select * from Championship where Deletado = 0").ToList();
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

        public void Update(Championship obj)
        {
            obj.DataDeAtualizacao = DateTime.Now;
            _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}

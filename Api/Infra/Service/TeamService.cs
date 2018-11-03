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
    public class TeamService : IRepository<Team>
    {
        private DataContext _context;
        private IConfiguration Configuration { get; }
        private readonly string _connection;

        public TeamService(DataContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
            _connection = Configuration.GetSection("SQLConnection:ConnectionString").Value;
        }


        public void Add(Team obj)
        {
            obj.DataDeCriacao = DateTime.Now;
            obj.DataDeAtualizacao = DateTime.Now;
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Team Get(int id)
        {
            SqlConnection conexao = new SqlConnection(_connection);
            conexao.Open();
            var vm = conexao.Query<Team>("select * from Team where id = @id and Deletado = 0 ", new { id = id }).FirstOrDefault();
            conexao.Close();

            return vm;
        }

        public IList<Team> GetAll()
        {
            SqlConnection conexao = new SqlConnection(_connection);
            conexao.Open();
            var vm = conexao.Query<Team>("select * from Team where Deletado = 0").ToList();
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

        public void Update(Team obj)
        {
            obj.DataDeAtualizacao = DateTime.Now;
            _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}

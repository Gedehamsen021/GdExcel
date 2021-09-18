using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GdExcel
{
    class Cliente
    {
        public int Id {  get; set; }
        public string Nome {  get; set; }
        public string Telefone {  get; set; }
        public DateTime Criacao {  get; set; }
        public int Gastos {  get; set; }

        public Cliente(int id, string nome, string telefone, DateTime criacao, int gastos)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Criacao = criacao;
            Gastos = gastos;
        }
    }
}

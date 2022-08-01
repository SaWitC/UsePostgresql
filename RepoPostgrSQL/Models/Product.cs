using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace RepoPostgrSQL.Models
{
    public class Product
    {
        //PostgreSQL
        //SqlServer
        public int Id { get; set; }
        public string Title { get; set; }
        public bool isused { get; set; }
        public DateTime dateTime { get; set; }
        public double cost { get; set; }
        public float CostDetails { get; set; }
        public byte ForByte { get; set; }
        public char symbol { get; set; }
        public enum enym { first, second }
        public long longtype{get;set;}
        public ulong ulongtype { get; set; }
        public uint uinttype { get; set; }
        public Decimal decimalType { get; set; }

        //PostgreSQL 

        //JSON

        //XML

        //IPV4 ; IPV6

        //UUID
        public int[] arr { get; set; }
        public double[,] arr3 { get; set; }
        
        //range

        //Nowhere

        ///public string[][] arr2 { get; set; }







    }
}

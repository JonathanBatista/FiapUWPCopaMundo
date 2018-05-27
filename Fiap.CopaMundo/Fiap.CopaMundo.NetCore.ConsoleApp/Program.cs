using Fiap.CopaMundo.EntityFramework.Contexts;
using Fiap.CopaMundo.EntityFramework.Migrations.SeedData;
using System;

namespace Fiap.CopaMundo.NetCore.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new CopaMundoContext())
            {
                CopaMundoSeedData.SeedCopaMundo(ctx);
            }
        }
    }
}

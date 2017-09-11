using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cfdb.DAL.DataSet;
using cfdb.Models;

namespace CodeFirstNewDatabaseSample
{
    class CodeFirstProgram
    {
        static void Main(string[] args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            BloggingContext bc = new BloggingContext();

            Console.WriteLine("Input Blog Name: ");
            string bname = Console.ReadLine();

            var b0 = new Blog() { Name = bname };
            bc.Blogs.Add(b0);
            bc.SaveChanges();

            var b0rz = from b in bc.Blogs
                       orderby b.Name
                       select b;

            foreach (var i in b0rz)
            {
                Console.WriteLine("34 -- BlogName: {0}.", i.Name);
            }            
            
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yieldSample01
{
    class Program
    {
        
        /// <summary>
        /// 回傳 User000 - User004 (by 一般的方式)
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<Employee> GetEmployees1()
        {
            List<Employee> emps = new List<Employee>();
            for (int i = 0; i < 5; i++)
            {
                emps.Add(new Employee() { Id = String.Format("{0:D3}", i), Name = "User" + String.Format("{0:D3}", i) });
            }
            return emps;
        }

        /// <summary>
        /// 回傳 User000 - User004 (by yield)
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<Employee> GetEmployees2()
        {
            for (int i = 0; i < 5; i++)
            {
                yield return (new Employee() { Id = String.Format("{0:D3}", i), Name = "User" + String.Format("{0:D3}", i) });
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("===== Without yield ====");
            IEnumerable<Employee> emps1 = GetEmployees1();
            foreach (var item in emps1)
            {
                Console.WriteLine("Id={0}, Name={1}", item.Id, item.Name);
            }

            Console.WriteLine("===== With yield ====");
            IEnumerable<Employee> emps2 = GetEmployees2();
            foreach (var item in emps2)
            {
                Console.WriteLine("Id={0}, Name={1}", item.Id, item.Name);
            }


            Console.ReadLine();

            ////Output:
            //===== Without yield ====
            //Id=000, Name=User000
            //Id=001, Name=User001
            //Id=002, Name=User002
            //Id=003, Name=User003
            //Id=004, Name=User004
            //===== With yield ====
            //Id=000, Name=User000
            //Id=001, Name=User001
            //Id=002, Name=User002
            //Id=003, Name=User003
            //Id=004, Name=User004

        }
    }
}

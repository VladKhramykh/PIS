using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет

            string text1 = "struct group_info init_groups = { .usage = ATOMIC_INIT(2) };" +
"struct group_info *groups_alloc(int gdnetsize)" +
 "       {" +
  "  struct group_info *group_info;" +
    "int nblocks;" +
     "   int i;" +
      "  nblocks = (gidsetsize + NGROUPS_PER_BLOCK - 1) / NGROUPS_PER_BLOCK;" +
    "/* Make sure we always allocate at least one indirect block pointer */" +
    "nblocks = nblocks? : 1;" +
    "group_info = kmalloc(sizeof(* group_info) + nblocks*sizeof(gid_t*), GFP_USER);" +
    "if (!group_info)" + ";" + "ЛООООХ";


            for (;;)
            {
                Console.Write(text1);
            }

        }
    }
}

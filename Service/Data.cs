using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal class Data
    {
    }

    public class AllNews : IAddData<J1>
    {
        public List<J1> Data { get; set; } = new List<J1>();
    }


    public class J1
    {
        public string Txt { get; set; }

        public string idnew { get; set; }
    }

    class Liststr : IAddData<J2>
    {
        public List<J2> Data { get; set; } = new List<J2>();
    }

    public class J2
    {
        public string idnew { get; set; }
        public string img { get; set; }
    }

    public class J3
    {
        public string idnew { get; set; }

        public string SH { get; set; }
    }

    class ListJ3 : IAddData<J3>
    {
        public List<J3> Data { get; set; } = new List<J3>();
    }
}


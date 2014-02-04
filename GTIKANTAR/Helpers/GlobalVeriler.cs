using GTIKANTAR.DataType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTIKANTAR.Helpers
{
   static class GlobalVeriler
    {
        public static EMPLOYEES ACTIVEUSER { get; set; }
        public static KANTARLAR ACTIVEKANTAR { get; set; }
        public static bool KantarYonu { get; set; }//true ise türkiye yönünde, false ise çıkış yönünde.
    }
}

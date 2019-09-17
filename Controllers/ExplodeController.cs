using System;
using System.Linq;
namespace Explode
{
  class Program
  {
    public static string Explode(string s)
    {
      return string.Join("", s.Select(a => new String(a, int.Parse(a.ToString()))));
    }

    static void Main(string[] args)
    {
    }
  }
}


using System.Collections;
using System.Collections.Generic;

namespace LeanringWithMosh.DropCode
{
    public class Foo
    {
        public static IEnumerable<int> Boo()
        {
            for(int i = 0; i < 4; i++)
            { 
                yield return i;
            }
        }
    }
}
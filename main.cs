using System;
using System.Collections.Generic;
using System.Linq;

class Program {

  public static bool containsCommonItem(string[] arr1, string[] arr2)
  {

    for(int i = 0; i < arr1.Length; i++)
    {
        for(int j = 0; j < arr2.Length; j++)
        {
          if (arr1[i] == arr2[j])
            return true;
        }
    }

    return false;
  }

  public static bool containsCommonItem2(string[] arr1, string[] arr2)
  {
    var result = arr1.Where(a => arr2.Contains(a))   
                  .ToList();

    return (result.Count() > 0);
  }

  public static void Main (string[] args) {

    string[] array1 = new string[]{"a", "b","c","x"};
    string[] array2 = new string[]{"y","x","z"};

    //bool containsCommonItens = containsCommonItem(array1,array2);
    bool containsCommonItens = containsCommonItem2(array1,array2);

    Console.WriteLine ("containsCommonItem: "+ containsCommonItens.ToString());
  }
}
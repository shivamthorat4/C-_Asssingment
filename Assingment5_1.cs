using System;
class Demo {
   static void Main() 
   {
      int[] arr = {1,11,54,53,2,21,544,66,22,3,43};
      int[] arr2 = new int[11];
      
      // sort
      Array.Sort(arr);
      Console.WriteLine("Sorted Array");
      foreach (int res in arr) 
      {
      Console.Write("\n"+res);
      }
            
        //Reverse
      Array.Reverse(arr);
      Console.WriteLine("Reverse Array");

      foreach (int ress in arr)
      {
      Console.Write("\n"+ress);
      }
      
      //Copy arr in arr2
      Array.Copy(arr, arr2, 11);

        Console.WriteLine("Copy Array");
        foreach (int value in arr2)
        {
            Console.WriteLine(value);
   }
     //Clear the Array
      Array.Clear(arr, 0, arr.Length);
      Console.WriteLine("Array After Clear:");
      foreach (int val in arr) {
         Console.WriteLine(val);
}
}
}

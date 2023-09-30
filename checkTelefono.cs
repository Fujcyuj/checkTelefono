using System;
using System.Collections.Generic;

public static class Telefono
{

   public static string Check(string[] inputStr) {
      
      //bool n = true;
      //string retVal= "";

      foreach( string input in inputStr ) {

         if( input.StartsWith("0039") ) {
            if( input.Length == 14 )
               return input;
         }
         else if( input.StartsWith("+39") ) {
            if( input.Length == 13 )
               return input;

         }
         else if( input.StartsWith("3") ) {
            Int64 valore=0;
            bool eUnNumero = Int64.TryParse( input, out valore );

            if( eUnNumero )
               if( input.Length == 10 )
                  return input;
         }

         /*
         if (input[0] == '3' && input.Length == 10) {
            for(int i = 1; i < input.Length || n == false; i++)  {
               if(input[i] != '1' || input[i] != '2' || input[i] != '3' || input[i] != '4' || input[i] != "5" || input[i] != "6" || input[i] != "7" || input[i] != "8" || input[i] != "9" || input[i] != "0")
                  n = false;
            }
         }
         else if (input[0] == "+" && input[1] == "3" && input[2] == "9" && input.Length == 13) {
            for(int i = 3; i < input.Length || n == false; i++)
            {
               if(input[i] != "1" || input[i] != "2" || input[i] != "3" || input[i] != "4" || input[i] != "5" || input[i] != "6" || input[i] != "7" || input[i] != "8" || input[i] != "9" || input[i] != "0")
                  n = false;
            }
         }
         else if (input[0] == "0" && input[1] == "0" && input[3] == "3" && input[4] == "9" && input.Length == 14){
            for(int i = 5; i < input.Length || n == false; i++)
            {
               if(input[i] != "1" || input[i] != "2" || input[i] != "3" || input[i] != "4" || input[i] != "5" || input[i] != "6" || input[i] != "7" || input[i] != "8" || input[i] != "9" || input[i] != "0")
                  n = false;
            }
         }
         else {
            n = false;
         }
         */           
      }

      return "";

      //return retVal;

   }     
}
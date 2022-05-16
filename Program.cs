// See https://aka.ms/new-console-template for more information
using System;     
class Program    
{    
    static  string password="soL44Sol";  
   static void Main(string []args)       
   {
      // string password="solaris";     

      //TO CHECK PASSWORD LENGTH
      try{
         if(password.Length<8){
            throw new Exception("The password is less than 8 digits");
         }
         
         ValidateNull();
      }
      catch(Exception e){
         Console.WriteLine(e.Message);
      }

      //TO CHECH PASSWORD NULL OR NOT
      static void  ValidateNull(){
         try{
           if(string.IsNullOrWhiteSpace(password)){
            throw new Exception("The password cannot be null");
           }
         
         ValidateDigit();
      }
      catch(Exception e){
         Console.WriteLine(e.Message);
      }
      }

         //TO CHECK PASSWORD CONTAINS DIGIT
        static void  ValidateDigit(){
         try{
           if(!password.Any(char.IsDigit)){
            throw new Exception("The password should have atleast one digit");
           }
         
         ValidateUpper();
      }
      catch(Exception e){
         Console.WriteLine(e.Message);
      }
      }

      //TO CHECK IT CONTAINS UPPER CASE OR NOT
        static void  ValidateUpper(){
         try{
           if(!password.Any(char.IsUpper)){
            throw new Exception("The password should contain uppercase");
           }
         
         ValidateLower();
      }
      catch(Exception e){
         Console.WriteLine(e.Message);
      }
      }

         //TO CHECK IT CONTAINS LOWER CASE OR NOT
        static void  ValidateLower(){
         try{
           if(!password.Any(char.IsLower)){
            throw new Exception("The password should contain lower case");
           }
         
         Console.WriteLine("The password is valid");
      }
      catch(Exception e){
         Console.WriteLine(e.Message);
      }
      }
      

   }    
}
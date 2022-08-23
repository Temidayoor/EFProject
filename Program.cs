using System;
using System.Linq;
using EFProject.Models;
using EFProject.Utils;
using EntityFramework.Exceptions.Common;
using Microsoft.Data.SqlClient;

namespace EFProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           // EFCoreInsert();
           // EFCoreUpdate();
            EFCoreDelete();
        }

        static void EFCoreInsert()
        {
            try
            {
                var db = new bankappdbContext();
                var stud = new Student();
                stud.Dob = new DateTime(1990, 12, 12);
                stud.FirstName = "Tosin";
                stud.LastName = "jegede";
                stud.MatricNo = "0123456789";
                stud.Class = "Year 4";
                db.Students.Add(stud);
                var noOfInsertRows = db.SaveChanges();
                Console.WriteLine($"{noOfInsertRows} row(s) was inserted successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }


        }

        static void EFCoreUpdate()
        {
            try
            {
                var db = new bankappdbContext();
            var wantedStud=    db.Students.Where(x => x.Id == 0).FirstOrDefault();
            wantedStud.FirstName = "Mark";
            wantedStud.Class = "Year 5";

            db.Update(wantedStud);
          var updatedRows =  db.SaveChanges();
          Console.WriteLine($"{updatedRows} row(s) was updated successfully");

            }
            catch (UniqueConstraintException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }


        }

        static void EFCoreDelete()
        {
            try
            {
                var db = new bankappdbContext();
                var wantedStud = db.Students.Where(x => x.Id == 0).FirstOrDefault();
                

                db.Students.Remove(wantedStud);
                var deletedRow = db.SaveChanges();
                Console.WriteLine($"{deletedRow} row(s) was deleted successfully");

            }
            catch (UniqueConstraintException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }


        }
        static void MethodChain() //METHOD CHAINING
        {
            string[] tasks = { "collect", "pay" };

            var eod = new EndOfDay(tasks.ToList());

            var output = eod
                .CheckSystem()
                .AddApproval("Mac")
                .RemoveTax()
                .CloseDay();


        }
    }
}
